
namespace SignToolsGUI
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            this.AddImage = new System.Windows.Forms.Button();
            this.OpenMap = new System.Windows.Forms.Button();
            this.mapdir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Locations = new System.Windows.Forms.ComboBox();
            this.SaveMap = new System.Windows.Forms.Button();
            this.SignPosLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SignType = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.RemoveImage = new System.Windows.Forms.Button();
            this.RemoveSkin = new System.Windows.Forms.Button();
            this.SkinPosLabel = new System.Windows.Forms.Label();
            this.SkinLocations = new System.Windows.Forms.ComboBox();
            this.AddSkin = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Framenumber = new System.Windows.Forms.MaskedTextBox();
            this.framelabel = new System.Windows.Forms.Label();
            this.FrameUp = new System.Windows.Forms.Button();
            this.Framedown = new System.Windows.Forms.Button();
            this.Plugins = new System.Windows.Forms.Button();
            this.scaledown = new System.Windows.Forms.Button();
            this.scaleup = new System.Windows.Forms.Button();
            this.scalelabel = new System.Windows.Forms.Label();
            this.scaletxt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePreview
            // 
            this.ImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePreview.Location = new System.Drawing.Point(30, 177);
            this.ImagePreview.Margin = new System.Windows.Forms.Padding(6);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(1238, 508);
            this.ImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePreview.TabIndex = 0;
            this.ImagePreview.TabStop = false;
            // 
            // AddImage
            // 
            this.AddImage.Enabled = false;
            this.AddImage.Location = new System.Drawing.Point(644, 85);
            this.AddImage.Margin = new System.Windows.Forms.Padding(6);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(200, 48);
            this.AddImage.TabIndex = 1;
            this.AddImage.Text = "Add Image";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // OpenMap
            // 
            this.OpenMap.Location = new System.Drawing.Point(24, 85);
            this.OpenMap.Margin = new System.Windows.Forms.Padding(6);
            this.OpenMap.Name = "OpenMap";
            this.OpenMap.Size = new System.Drawing.Size(200, 48);
            this.OpenMap.TabIndex = 2;
            this.OpenMap.Text = "Open Map";
            this.OpenMap.UseVisualStyleBackColor = true;
            this.OpenMap.Click += new System.EventHandler(this.OpenMap_Click);
            // 
            // mapdir
            // 
            this.mapdir.Enabled = false;
            this.mapdir.Location = new System.Drawing.Point(24, 37);
            this.mapdir.Margin = new System.Windows.Forms.Padding(6);
            this.mapdir.Name = "mapdir";
            this.mapdir.Size = new System.Drawing.Size(592, 31);
            this.mapdir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Map:";
            // 
            // Locations
            // 
            this.Locations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Locations.Enabled = false;
            this.Locations.FormattingEnabled = true;
            this.Locations.Location = new System.Drawing.Point(644, 37);
            this.Locations.Margin = new System.Windows.Forms.Padding(6);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(408, 33);
            this.Locations.TabIndex = 5;
            this.Locations.SelectedIndexChanged += new System.EventHandler(this.Selection);
            // 
            // SaveMap
            // 
            this.SaveMap.Enabled = false;
            this.SaveMap.Location = new System.Drawing.Point(236, 85);
            this.SaveMap.Margin = new System.Windows.Forms.Padding(6);
            this.SaveMap.Name = "SaveMap";
            this.SaveMap.Size = new System.Drawing.Size(200, 48);
            this.SaveMap.TabIndex = 7;
            this.SaveMap.Text = "Save Map";
            this.SaveMap.UseVisualStyleBackColor = true;
            this.SaveMap.Click += new System.EventHandler(this.SaveMap_Click);
            // 
            // SignPosLable
            // 
            this.SignPosLable.AutoSize = true;
            this.SignPosLable.Location = new System.Drawing.Point(638, 6);
            this.SignPosLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SignPosLable.Name = "SignPosLable";
            this.SignPosLable.Size = new System.Drawing.Size(155, 25);
            this.SignPosLable.TabIndex = 8;
            this.SignPosLable.Text = "Sign Positions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item:";
            // 
            // SignType
            // 
            this.SignType.AutoSize = true;
            this.SignType.Location = new System.Drawing.Point(116, 146);
            this.SignType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SignType.Name = "SignType";
            this.SignType.Size = new System.Drawing.Size(0, 25);
            this.SignType.TabIndex = 10;
            this.SignType.Visible = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(92, 146);
            this.name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 25);
            this.name.TabIndex = 11;
            // 
            // RemoveImage
            // 
            this.RemoveImage.Enabled = false;
            this.RemoveImage.Location = new System.Drawing.Point(856, 85);
            this.RemoveImage.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveImage.Name = "RemoveImage";
            this.RemoveImage.Size = new System.Drawing.Size(200, 48);
            this.RemoveImage.TabIndex = 12;
            this.RemoveImage.Text = "Remove Image";
            this.RemoveImage.UseVisualStyleBackColor = true;
            this.RemoveImage.Click += new System.EventHandler(this.RemoveImage_Click);
            // 
            // RemoveSkin
            // 
            this.RemoveSkin.Enabled = false;
            this.RemoveSkin.Location = new System.Drawing.Point(1583, 85);
            this.RemoveSkin.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveSkin.Name = "RemoveSkin";
            this.RemoveSkin.Size = new System.Drawing.Size(200, 48);
            this.RemoveSkin.TabIndex = 16;
            this.RemoveSkin.Text = "Remove Skin";
            this.RemoveSkin.UseVisualStyleBackColor = true;
            this.RemoveSkin.Click += new System.EventHandler(this.RemoveSkin_Click);
            // 
            // SkinPosLabel
            // 
            this.SkinPosLabel.AutoSize = true;
            this.SkinPosLabel.Location = new System.Drawing.Point(1365, 6);
            this.SkinPosLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SkinPosLabel.Name = "SkinPosLabel";
            this.SkinPosLabel.Size = new System.Drawing.Size(154, 25);
            this.SkinPosLabel.TabIndex = 15;
            this.SkinPosLabel.Text = "Skin Positions:";
            // 
            // SkinLocations
            // 
            this.SkinLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkinLocations.Enabled = false;
            this.SkinLocations.FormattingEnabled = true;
            this.SkinLocations.Location = new System.Drawing.Point(1371, 37);
            this.SkinLocations.Margin = new System.Windows.Forms.Padding(6);
            this.SkinLocations.Name = "SkinLocations";
            this.SkinLocations.Size = new System.Drawing.Size(408, 33);
            this.SkinLocations.TabIndex = 14;
            this.SkinLocations.SelectedIndexChanged += new System.EventHandler(this.Selection2);
            // 
            // AddSkin
            // 
            this.AddSkin.Enabled = false;
            this.AddSkin.Location = new System.Drawing.Point(1371, 85);
            this.AddSkin.Margin = new System.Windows.Forms.Padding(6);
            this.AddSkin.Name = "AddSkin";
            this.AddSkin.Size = new System.Drawing.Size(200, 48);
            this.AddSkin.TabIndex = 13;
            this.AddSkin.Text = "Add Skin";
            this.AddSkin.UseVisualStyleBackColor = true;
            this.AddSkin.Click += new System.EventHandler(this.AddSkin_Click);
            // 
            // Import
            // 
            this.Import.Enabled = false;
            this.Import.Location = new System.Drawing.Point(1839, 12);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(245, 64);
            this.Import.TabIndex = 17;
            this.Import.Text = "Import Settings";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Export
            // 
            this.Export.Enabled = false;
            this.Export.Location = new System.Drawing.Point(1839, 82);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(245, 57);
            this.Export.TabIndex = 18;
            this.Export.Text = "Export Settings";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Framenumber
            // 
            this.Framenumber.Enabled = false;
            this.Framenumber.Location = new System.Drawing.Point(1097, 39);
            this.Framenumber.Mask = "0";
            this.Framenumber.Name = "Framenumber";
            this.Framenumber.Size = new System.Drawing.Size(88, 31);
            this.Framenumber.TabIndex = 19;
            this.Framenumber.Text = "0";
            this.Framenumber.TextChanged += new System.EventHandler(this.Framenumber_TextChanged);
            // 
            // framelabel
            // 
            this.framelabel.AutoSize = true;
            this.framelabel.Location = new System.Drawing.Point(1092, 6);
            this.framelabel.Name = "framelabel";
            this.framelabel.Size = new System.Drawing.Size(79, 25);
            this.framelabel.TabIndex = 20;
            this.framelabel.Text = "Frame:";
            // 
            // FrameUp
            // 
            this.FrameUp.Enabled = false;
            this.FrameUp.Location = new System.Drawing.Point(1097, 85);
            this.FrameUp.Name = "FrameUp";
            this.FrameUp.Size = new System.Drawing.Size(41, 38);
            this.FrameUp.TabIndex = 21;
            this.FrameUp.Text = "▲";
            this.FrameUp.UseVisualStyleBackColor = true;
            this.FrameUp.Click += new System.EventHandler(this.FrameUp_Click);
            // 
            // Framedown
            // 
            this.Framedown.Enabled = false;
            this.Framedown.Location = new System.Drawing.Point(1144, 85);
            this.Framedown.Name = "Framedown";
            this.Framedown.Size = new System.Drawing.Size(41, 38);
            this.Framedown.TabIndex = 22;
            this.Framedown.Text = "▼";
            this.Framedown.UseVisualStyleBackColor = true;
            this.Framedown.Click += new System.EventHandler(this.Framedown_Click);
            // 
            // Plugins
            // 
            this.Plugins.Enabled = false;
            this.Plugins.Location = new System.Drawing.Point(445, 85);
            this.Plugins.Name = "Plugins";
            this.Plugins.Size = new System.Drawing.Size(171, 48);
            this.Plugins.TabIndex = 23;
            this.Plugins.Text = "Plugins";
            this.Plugins.UseVisualStyleBackColor = true;
            this.Plugins.Click += new System.EventHandler(this.Plugins_Click);
            // 
            // scaledown
            // 
            this.scaledown.Location = new System.Drawing.Point(1271, 85);
            this.scaledown.Name = "scaledown";
            this.scaledown.Size = new System.Drawing.Size(41, 38);
            this.scaledown.TabIndex = 27;
            this.scaledown.Text = "▼";
            this.scaledown.UseVisualStyleBackColor = true;
            this.scaledown.Click += new System.EventHandler(this.scaledown_Click);
            // 
            // scaleup
            // 
            this.scaleup.Location = new System.Drawing.Point(1224, 85);
            this.scaleup.Name = "scaleup";
            this.scaleup.Size = new System.Drawing.Size(41, 38);
            this.scaleup.TabIndex = 26;
            this.scaleup.Text = "▲";
            this.scaleup.UseVisualStyleBackColor = true;
            this.scaleup.Click += new System.EventHandler(this.scaleup_Click);
            // 
            // scalelabel
            // 
            this.scalelabel.AutoSize = true;
            this.scalelabel.Location = new System.Drawing.Point(1219, 7);
            this.scalelabel.Name = "scalelabel";
            this.scalelabel.Size = new System.Drawing.Size(72, 25);
            this.scalelabel.TabIndex = 25;
            this.scalelabel.Text = "Scale:";
            // 
            // scaletxt
            // 
            this.scaletxt.Location = new System.Drawing.Point(1224, 39);
            this.scaletxt.Mask = "0.00";
            this.scaletxt.Name = "scaletxt";
            this.scaletxt.Size = new System.Drawing.Size(88, 31);
            this.scaletxt.TabIndex = 24;
            this.scaletxt.Text = "100";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2112, 1233);
            this.Controls.Add(this.scaledown);
            this.Controls.Add(this.scaleup);
            this.Controls.Add(this.scalelabel);
            this.Controls.Add(this.scaletxt);
            this.Controls.Add(this.Plugins);
            this.Controls.Add(this.Framedown);
            this.Controls.Add(this.FrameUp);
            this.Controls.Add(this.framelabel);
            this.Controls.Add(this.Framenumber);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.RemoveSkin);
            this.Controls.Add(this.SkinPosLabel);
            this.Controls.Add(this.SkinLocations);
            this.Controls.Add(this.AddSkin);
            this.Controls.Add(this.RemoveImage);
            this.Controls.Add(this.name);
            this.Controls.Add(this.SignType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SignPosLable);
            this.Controls.Add(this.SaveMap);
            this.Controls.Add(this.Locations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapdir);
            this.Controls.Add(this.OpenMap);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.ImagePreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.Text = "SignToolsGUI 007";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagePreview;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.Button OpenMap;
        private System.Windows.Forms.TextBox mapdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Locations;
        private System.Windows.Forms.Button SaveMap;
        private System.Windows.Forms.Label SignPosLable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SignType;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button RemoveImage;
        private System.Windows.Forms.Button RemoveSkin;
        private System.Windows.Forms.Label SkinPosLabel;
        private System.Windows.Forms.ComboBox SkinLocations;
        private System.Windows.Forms.Button AddSkin;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.MaskedTextBox Framenumber;
        private System.Windows.Forms.Label framelabel;
        private System.Windows.Forms.Button FrameUp;
        private System.Windows.Forms.Button Framedown;
        private System.Windows.Forms.Button Plugins;
        private System.Windows.Forms.Button scaledown;
        private System.Windows.Forms.Button scaleup;
        private System.Windows.Forms.Label scalelabel;
        private System.Windows.Forms.MaskedTextBox scaletxt;
    }
}

