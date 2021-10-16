using LZ4;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SignToolsGUI
{
    public partial class Form1 : Form
    {
        WorldSerialization worldSerialization = new WorldSerialization();
        uint Version;
        Dictionary<string, byte[]> SerializedImageData = new Dictionary<string, byte[]>();
        Dictionary<string, byte[]> ModdedSerializedImageData = new Dictionary<string, byte[]>();
        Dictionary<string, uint> SerializedSkinData = new Dictionary<string, uint>();
        Dictionary<string, uint> ModdedSerializedSkinData = new Dictionary<string, uint>();
        uint[] signids = { 1447270506, 4057957010, 120534793, 58270319, 4290170446, 3188315846, 3215377795, 1960724311, 3159642196, 3725754530, 1957158128, 637495597, 1283107100, 4006597758, 3715545584, 3479792512, 3618197174, 550204242 };
        uint[] skinnableids = { 1844023509, 177343599, 3994459244, 4196580066, 3110378351, 2206646561, 2931042549, 159326486, 2245774897, 1560881570, 3647679950, 170207918, 202293038, 1343928398, 43442943, 201071098, 1418678061, 2662124780 };
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
        private Dictionary<string, string> _Names = new Dictionary<string, string>
        {
            {"4006597758", "spinner.wheel"},
            {"3215377795",  "sign.pictureframe.landscape"},
            {"3159642196",  "sign.pictureframe.tall"},
            {"1960724311",  "sign.pictureframe.portrait"},
            {"3725754530",  "sign.pictureframe.xxl"},
            {"1957158128", "sign.pictureframe.xl"},
            {"1447270506",  "sign.small.wood"},
            {"3715545584",  "sign.medium.wood"},
            {"3479792512",  "sign.large.wood"},
            {"3618197174",  "sign.huge.wood"},
            {"637495597",  "sign.hanging.banner.large"},
            {"3188315846",  "sign.pole.banner.large"},
            {"58270319",  "sign.post.single"},
            {"4290170446",  "sign.post.double"},
            {"120534793",  "sign.post.town"},
            {"4057957010", "sign.post.town.roof"},
            {"550204242",  "sign.hanging"},
            {"1283107100",  "sign.hanging.ornate"},
            {"1844023509", "Fridge" },
            {"177343599", "Lockers" },
            {"3994459244", "Reactive.Target" },
            {"4196580066", "Rug" },
            {"3110378351", "Rug.Bear" },
            {"2206646561", "Box.Large" },
            {"2931042549","Furnace" },
            {"159326486", "Sleeping.Bag" },
            {"2245774897","VendingMachine" },
            {"1560881570","Box.Small" },
            {"3647679950","GarageDoor" },
            {"170207918","ArmourDoor" },
            {"202293038","MetalDoor" },
            {"1343928398","WoodDoor" },
            {"43442943","Double.WoodDoor" },
            {"201071098","Double.ArmourDoor" },
            {"1418678061","Double.MetalDoor" },
            {"2662124780","Table" }

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
                SerializedImageData.Add("(" + x + ", " + y + ", " + z + ")", ImageData);
            }
        }
        void XMLDecodeSkin(string SerialData)
        {
            string[] DataParse = SerialData.Split(new string[] { "<position>" }, StringSplitOptions.None);
            foreach (string xmldata in DataParse)
            {
                if (xmldata.Contains("xml version")) continue;
                string x = xmldata.Split(new string[] { "</x><y>" }, StringSplitOptions.None)[0].Replace("<x>", "");
                string y = xmldata.Split(new string[] { "</y><z>" }, StringSplitOptions.None)[0].Replace("<x>" + x + "</x><y>", "");
                string z = xmldata.Split(new string[] { "</z></position>" }, StringSplitOptions.None)[0].Replace("<x>" + x + "</x><y>" + y + "</y><z>", "");
                uint skinid = uint.Parse(xmldata.Split(new string[] { "<skin>" }, StringSplitOptions.None)[1].Replace("</skin>", "").Replace("</SerializedSkinData>", ""));
                SerializedSkinData.Add("(" + x + ", " + y + ", " + z + ")", skinid);
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
        string XMLEncodeSkin()
        {
            string XMLData = @"<? xml version=""1.0""?><SerializedSkinData>";
            string SerialData = "";
            foreach (KeyValuePair<string, uint> _skin in ModdedSerializedSkinData)
            {
                string[] xmlbreakdown = _skin.Key.Replace("(", "").Replace(" ", "").Replace(")", "").Split(',');


                SerialData += ("<position>" +
                               "<x>" + xmlbreakdown[0] + "</x>" +
                               "<y>" + xmlbreakdown[1] + "</y>" +
                               "<z>" + xmlbreakdown[2] + "</z>" +
                               "</position>" +
                               "<skin>" +
                               _skin.Value +
                               "</skin>");
            }
            XMLData = XMLData + SerialData + "</SerializedSkinData>";
            return XMLData;
        }

        private void DisableButtons()
        {
            SaveMap.Enabled = false;
            Locations.Enabled = false;
            AddImage.Enabled = false;
            ImagePreview.Enabled = false;
            RemoveImage.Enabled = false;
        }
        private bool isSign(PrefabData sign)
        {
            //Checks prefab has a valid sign id
            return (signids.Contains(sign.id));
        }

        private bool isSkinnable(PrefabData entity)
        {
            //Checks prefab has a valid skinnable id
            return (skinnableids.Contains(entity.id));
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
            SkinLocations.Items.Clear();
            SerializedSkinData.Clear();
            ModdedSerializedSkinData.Clear();

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
                        else if (mapdata.name == Base64Encode("SerializedSkinData"))
                        {
                            XMLDecodeSkin(System.Text.Encoding.ASCII.GetString(mapdata.data));
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

                            if (SerializedImageData.ContainsKey(location))
                            {
                                ModdedSerializedImageData.Add(location, SerializedImageData[location]);
                            }
                            else
                            {
                                ModdedSerializedImageData.Add(location, new byte[0]);
                            }
                        }
                        else if (isSkinnable(prefabdata))
                        {
                            string location = "(" + prefabdata.position.x.ToString("0.0") + ", " + prefabdata.position.y.ToString("0.0") + ", " + prefabdata.position.z.ToString("0.0") + ")";
                            SkinLocations.Items.Add(location + " " + prefabdata.id.ToString());
                            if (SerializedSkinData.ContainsKey(location))
                            {
                                ModdedSerializedSkinData.Add(location, SerializedSkinData[location]);
                            }
                            else
                            {
                                ModdedSerializedSkinData.Add(location, 0);
                            }
                        }
                    }

                    if (Locations.Items.Count != 0)
                    {
                        Locations.Text = Locations.Items[0].ToString();
                    }
                    else if (SkinLocations.Items.Count != 0)
                    {
                        Locations.Text = SkinLocations.Items[0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No signs or skinnable items are on this map");
                        return;
                    }

                    SaveMap.Enabled = true;
                    Locations.Enabled = true;
                    AddImage.Enabled = true;
                    ImagePreview.Enabled = true;
                    SignType.Enabled = true;
                    RemoveImage.Enabled = true;
                    SkinLocations.Enabled = true;
                    AddSkin.Enabled = true;
                    RemoveSkin.Enabled = true;
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
            name.Text = _Names[SignType.Text];
            Size size = new Size(_signSizes[SignType.Text].Width, _signSizes[SignType.Text].Height);
            ImagePreview.Size = size;
            if (ModdedSerializedImageData.ContainsKey(selected[0] + ")"))
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
        private void Selection2(object sender, EventArgs e)
        {
            string[] selected = SkinLocations.GetItemText(SkinLocations.SelectedItem).Split(')');
            SignType.Text = selected[1].Replace(" ", "");
            name.Text = _Names[SignType.Text];
            Size size = new Size(1024, 512);
            ImagePreview.Size = size;
            try
            {
                if (ModdedSerializedSkinData[selected[0] + ")"] != 0)
                {
                    if (ModdedSerializedSkinData.ContainsKey(selected[0] + ")"))
                    {
                        ImagePreview.Image = GetThumbNail(ModdedSerializedSkinData[selected[0] + ")"]);
                        return;
                    }
                }
            }
            catch { }
                ImagePreview.Image = null;
        }

        private Bitmap GetThumbNail(uint skinid)
            {
            try
            {
                WebClient wc = new WebClient();
                string html = wc.DownloadString("https://steamcommunity.com/sharedfiles/filedetails/?id=" + skinid);
                string[] thumbnailparse = html.Split(new string[] { "workshopItemPreviewImageEnlargeable" }, StringSplitOptions.None);
                string[] thumbimage = thumbnailparse[2].Split(new string[] { "/>" }, StringSplitOptions.None);
                string[] imageparse = thumbimage[0].Split(new string[] { "https://" }, StringSplitOptions.None);
                string image = "";
                try
                {
                    image = "https://" + imageparse[3].Replace(@"""", "");
                }
                catch
                {
                    try
                    {
                        image = "https://" + imageparse[2].Replace(@"""", "");
                    }
                    catch
                    {
                        try
                        {
                            image = "https://" + imageparse[1].Replace(@"""", "");
                        }
                        catch { }
                    }
                }
                try
                {
                    byte[] imagedata = wc.DownloadData(image);
                    if (imagedata.Length > 0)
                    {
                        return ByteToImage(imagedata);
                    }
                }
                catch { }
            }
            catch { }
            return null;
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
            string XMLDataSkin = XMLEncodeSkin();
            //Check if mapdata already has image data
            MapData sd = worldSerialization.GetMap(Base64Encode("SerializedImageData"));
            MapData ssd = worldSerialization.GetMap(Base64Encode("SerializedSkinData"));
            if (sd == null)
            {
                worldSerialization.AddMap(Base64Encode("SerializedImageData"), Encoding.ASCII.GetBytes(XMLData));
            }
            else
            {
                sd.data = Encoding.ASCII.GetBytes(XMLData);
            }
            if (ssd == null)
            {
                worldSerialization.AddMap(Base64Encode("SerializedSkinData"), Encoding.ASCII.GetBytes(XMLDataSkin));
            }
            else
            {
                ssd.data = Encoding.ASCII.GetBytes(XMLDataSkin);
            }
            string mapfile = mapdir.Text.Replace(".map",".Mod.map");
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

        private void RemoveImage_Click(object sender, EventArgs e)
        {
            string[] selected = Locations.GetItemText(Locations.SelectedItem).Split(')');
            ModdedSerializedImageData[selected[0] + ")"] = new byte[0];
            ImagePreview.Image = null;
        }

        private static void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Skin ID";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(NumbersOnly_KeyPress);
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void AddSkin_Click(object sender, EventArgs e)
        {
            string input = "0";
            uint skinid = 0;
            string[] selected = SkinLocations.GetItemText(SkinLocations.SelectedItem).Split(')');
            if (ModdedSerializedSkinData.ContainsKey(selected[0] + ")"))
            {

                input = ModdedSerializedSkinData[selected[0] + ")"].ToString();
                if(ShowInputDialog(ref input) == DialogResult.Cancel)
                {
                    return;
                }
                try
                {
                    skinid = uint.Parse(input);
                }
                catch { }

                if (skinid != 0)
                {
                    ModdedSerializedSkinData[selected[0] + ")"] = skinid;
                    ImagePreview.Image = GetThumbNail(skinid);

                }
            }
        }

        private void RemoveSkin_Click(object sender, EventArgs e)
        {
            string[] selected = SkinLocations.GetItemText(SkinLocations.SelectedItem).Split(')');
            ModdedSerializedSkinData[selected[0] + ")"] = 0;
            ImagePreview.Image = null;
        }
    }
}
