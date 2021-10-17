
namespace SignToolsGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            this.AddImage = new System.Windows.Forms.Button();
            this.OpenMap = new System.Windows.Forms.Button();
            this.mapdir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Locations = new System.Windows.Forms.ComboBox();
            this.SaveMap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SignType = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.RemoveImage = new System.Windows.Forms.Button();
            this.RemoveSkin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SkinLocations = new System.Windows.Forms.ComboBox();
            this.AddSkin = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
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
            this.AddImage.Location = new System.Drawing.Point(674, 85);
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
            this.Locations.Location = new System.Drawing.Point(674, 37);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sign Positions:";
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
            this.RemoveImage.Location = new System.Drawing.Point(886, 85);
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
            this.RemoveSkin.Location = new System.Drawing.Point(1368, 85);
            this.RemoveSkin.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveSkin.Name = "RemoveSkin";
            this.RemoveSkin.Size = new System.Drawing.Size(200, 48);
            this.RemoveSkin.TabIndex = 16;
            this.RemoveSkin.Text = "Remove Skin";
            this.RemoveSkin.UseVisualStyleBackColor = true;
            this.RemoveSkin.Click += new System.EventHandler(this.RemoveSkin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1150, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Skin Positions:";
            // 
            // SkinLocations
            // 
            this.SkinLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SkinLocations.Enabled = false;
            this.SkinLocations.FormattingEnabled = true;
            this.SkinLocations.Location = new System.Drawing.Point(1156, 37);
            this.SkinLocations.Margin = new System.Windows.Forms.Padding(6);
            this.SkinLocations.Name = "SkinLocations";
            this.SkinLocations.Size = new System.Drawing.Size(408, 33);
            this.SkinLocations.TabIndex = 14;
            this.SkinLocations.SelectedIndexChanged += new System.EventHandler(this.Selection2);
            // 
            // AddSkin
            // 
            this.AddSkin.Enabled = false;
            this.AddSkin.Location = new System.Drawing.Point(1156, 85);
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
            this.Import.Location = new System.Drawing.Point(1600, 6);
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
            this.Export.Location = new System.Drawing.Point(1600, 76);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(245, 57);
            this.Export.TabIndex = 18;
            this.Export.Text = "Export Settings";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2112, 1233);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.RemoveSkin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SkinLocations);
            this.Controls.Add(this.AddSkin);
            this.Controls.Add(this.RemoveImage);
            this.Controls.Add(this.name);
            this.Controls.Add(this.SignType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Name = "Form1";
            this.Text = "SignToolsGUI 004";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SignType;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button RemoveImage;
        private System.Windows.Forms.Button RemoveSkin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SkinLocations;
        private System.Windows.Forms.Button AddSkin;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button Export;
    }
}

