using LZ4;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SignToolsGUI
{
    public partial class Form1 : Form
    {
        WorldSerialization worldSerialization = new WorldSerialization();
        uint Version;
        Dictionary<string, byte[]> SerializedImageData = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ModdedSerializedImageData = new Dictionary<string, byte[]>();
        uint[] signids = { 1447270506, 4057957010, 120534793, 58270319, 4290170446, 3188315846, 3215377795, 1960724311, 3159642196, 3725754530, 1957158128, 637495597, 1283107100, 4006597758, 3715545584, 3479792512, 3618197174, 550204242 };
        private Dictionary<string, SignSize> _signSizes = new Dictionary<string, SignSize>
        {
            {"4006597758", new SignSize(512, 512)},
            {"3215377795", new SignSize(256, 128)},
            {"3159642196", new SignSize(128, 512)},
            {"1960724311", new SignSize(128, 256)},
            {"3725754530", new SignSize(1024, 512)},
            {"1957158128", new SignSize(512, 512)},
            {"1447270506", new SignSize(128, 64)},
            {"3715545584", new SignSize(256, 128)},
            {"3479792512", new SignSize(256, 128)},
            {"3618197174", new SignSize(512, 128)},
            {"637495597", new SignSize(64, 256)},
            {"3188315846", new SignSize(64, 256)},
            {"58270319", new SignSize(128, 64)},
            {"4290170446", new SignSize(256, 256)},
            {"120534793", new SignSize(256, 128)},
            {"4057957010", new SignSize(256, 128)},
            {"550204242", new SignSize(128, 256)},
            {"1283107100", new SignSize(256, 128)},
        };
        private class SignSize
        {
            public int Width;
            public int Height;
            public SignSize(int width, int height)
            {
                Width = width;
                Height = height;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        void XMLDecode(string SerialData)
        {
            string[] DataParse = SerialData.Split(new string[] { "<position>" }, StringSplitOptions.None);
            foreach (string xmldata in DataParse)
            {
                if (xmldata.Contains("xml version")) continue;
                string x = xmldata.Split(new string[] { "</x><y>" }, StringSplitOptions.None)[0].Replace("<x>", "");
                string y = xmldata.Split(new string[] { "</y><z>" }, StringSplitOptions.None)[0].Replace("<x>" + x + "</x><y>", "");
                string z = xmldata.Split(new string[] { "</z></position>" }, StringSplitOptions.None)[0].Replace("<x>" + x + "</x><y>" + y + "</y><z>", "");
                string texture = xmldata.Split(new string[] { "<texture>" }, StringSplitOptions.None)[1].Replace("</texture>", "").Replace("</SerializedImageData>", "");
                byte[] ImageData = Convert.FromBase64String(texture);
                SerializedImageData.Add("("+ x+", "+y + ", "+z+")", ImageData);
            }
        }

        string XMLEncode()
        {
            string XMLData = @"<? xml version=""1.0""?><SerializedImageData>";
            string SerialData = "";
            foreach (KeyValuePair<string, byte[]> _sign in ModdedSerializedImageData)
            {
                if (_sign.Value.Length != 0)
                {
                    string[] xmlbreakdown = _sign.Key.Replace("(", "").Replace(" ", "").Replace(")", "").Split(',');


                    SerialData += ("<position>" +
                                   "<x>" + xmlbreakdown[0] + "</x>" +
                                   "<y>" + xmlbreakdown[1] + "</y>" +
                                   "<z>" + xmlbreakdown[2] + "</z>" +
                                   "</position>" +
                                   "<texture>" +
                                   Convert.ToBase64String(_sign.Value) +
                                   "</texture>");
                }
            }
            XMLData = XMLData + SerialData + "</SerializedImageData>";
            return XMLData;
        }

        private void DisableButtons()
        {
            SaveMap.Enabled = false;
            Locations.Enabled = false;
            AddImage.Enabled = false;
            ImagePreview.Enabled = false;
        }
        private bool isSign(PrefabData sign)
        {
            //Checks prefab has a valid sign id
            return (signids.Contains(sign.id));
        }

       
        byte[] ImageResize(byte[] imageBytes, int width, int height)
        {
            //Resize image to sign size.
            Bitmap resizedImage = new Bitmap(width, height),
                sourceImage = new Bitmap(new MemoryStream(imageBytes));

            Graphics.FromImage(resizedImage).DrawImage(sourceImage, new Rectangle(0, 0, width, height),
                new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), GraphicsUnit.Pixel);

            var ms = new MemoryStream();
            resizedImage.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }
        private void OpenMap_Click(object sender, EventArgs e)
        {
            Locations.Items.Clear();
            SerializedImageData.Clear();
            ModdedSerializedImageData.Clear();
                
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Rust Map File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "map",
                Filter = "map files (*.map)|*.map",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                mapdir.Text = openFileDialog1.FileName;
                try
                {
                    worldSerialization.Load(mapdir.Text);
                    Version = worldSerialization.Version;

                //Check for exsisting
                for (int i = worldSerialization.world.maps.Count - 1; i >= 0; i--)
                {
                    MapData mapdata = worldSerialization.world.maps[i];
                    if (mapdata.name == Base64Encode("SerializedImageData"))
                    {
                        XMLDecode(System.Text.Encoding.ASCII.GetString(mapdata.data));
                    }
                }

                //Scan all prefab in map file.
                for (int i = worldSerialization.world.prefabs.Count - 1; i >= 0; i--)
                {
                    PrefabData prefabdata = worldSerialization.world.prefabs[i];
                    if (isSign(prefabdata))
                    {
                        string location = "(" + prefabdata.position.x.ToString("0.0") + ", " + prefabdata.position.y.ToString("0.0") + ", " + prefabdata.position.z.ToString("0.0") + ")";
                        Locations.Items.Add(location + " " + prefabdata.id.ToString());

                        if(SerializedImageData.ContainsKey(location))
                        {
                            ModdedSerializedImageData.Add(location, SerializedImageData[location]);
                        }
                        else
                        {
                            ModdedSerializedImageData.Add(location, new byte[0]);
                        }
                    }
                }
                if(Locations.Items.Count == 0)
                {
                    MessageBox.Show("No Signs are on this map");
                    return;
                }
                    Locations.Text = Locations.Items[0].ToString();

                    SaveMap.Enabled = true;
                    Locations.Enabled = true;
                    AddImage.Enabled = true;
                    ImagePreview.Enabled = true;
                    SignType.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Failed to open map");
                    DisableButtons();
                }
            }
        }

        private void Selection(object sender, EventArgs e)
        {
            string[] selected = Locations.GetItemText(Locations.SelectedItem).Split(')');
            SignType.Text = selected[1].Replace(" ", "");
            Size size = new Size(_signSizes[SignType.Text].Width, _signSizes[SignType.Text].Height);
            ImagePreview.Size = size;
            if (ModdedSerializedImageData.ContainsKey(selected[0]+")"))
            {
                if (ModdedSerializedImageData[selected[0] + ")"].Length != 0)
                {
                    ImagePreview.Image = ByteToImage(ModdedSerializedImageData[selected[0] + ")"]);
                }
                else
                {
                    ImagePreview.Image = null;
                }
            }
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Image File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",
                Filter = "png files (*.png)|*.png",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                byte[] NewImage = ImageResize(File.ReadAllBytes(openFileDialog1.FileName), ImagePreview.Width, ImagePreview.Height);
                string[] selected = Locations.GetItemText(Locations.SelectedItem).Split(')');
                if (ModdedSerializedImageData.ContainsKey(selected[0] + ")"))
                {
                    ModdedSerializedImageData[selected[0] + ")"] = NewImage;
                    ImagePreview.Image = ByteToImage(ModdedSerializedImageData[selected[0] + ")"]);
                }
            }
        }

        private void SaveMap_Click(object sender, EventArgs e)
        {
            string XMLData = XMLEncode();
            //Check if mapdata already has image data
            MapData sd = worldSerialization.GetMap(Base64Encode("SerializedImageData"));
            if (sd == null)
            {
                worldSerialization.AddMap(Base64Encode("SerializedImageData"), Encoding.ASCII.GetBytes(XMLData));
            }
            else
            {
                sd.data = Encoding.ASCII.GetBytes(XMLData);
            }
            string mapfile = mapdir.Text.Replace(".map",".signs.map");
            if (File.Exists(mapfile))
            {
                File.Delete(mapfile);
            }
            using (FileStream fileStream = new FileStream(mapfile, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(Version);
                    using (LZ4Stream stream = new LZ4Stream(fileStream, LZ4StreamMode.Compress))
                    {
                        WorldData.Serialize(stream, worldSerialization.world);
                    }
                }
            }
            MessageBox.Show("Saved");
        }
    }
}
