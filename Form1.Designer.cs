
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
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePreview
            // 
            this.ImagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePreview.Location = new System.Drawing.Point(12, 129);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(298, 151);
            this.ImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagePreview.TabIndex = 0;
            this.ImagePreview.TabStop = false;
            // 
            // AddImage
            // 
            this.AddImage.Enabled = false;
            this.AddImage.Location = new System.Drawing.Point(210, 100);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(100, 23);
            this.AddImage.TabIndex = 1;
            this.AddImage.Text = "Add Image";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // OpenMap
            // 
            this.OpenMap.Location = new System.Drawing.Point(104, 45);
            this.OpenMap.Name = "OpenMap";
            this.OpenMap.Size = new System.Drawing.Size(100, 25);
            this.OpenMap.TabIndex = 2;
            this.OpenMap.Text = "Open Map";
            this.OpenMap.UseVisualStyleBackColor = true;
            this.OpenMap.Click += new System.EventHandler(this.OpenMap_Click);
            // 
            // mapdir
            // 
            this.mapdir.Enabled = false;
            this.mapdir.Location = new System.Drawing.Point(12, 19);
            this.mapdir.Name = "mapdir";
            this.mapdir.Size = new System.Drawing.Size(298, 20);
            this.mapdir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Map:";
            // 
            // Locations
            // 
            this.Locations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Locations.Enabled = false;
            this.Locations.FormattingEnabled = true;
            this.Locations.Location = new System.Drawing.Point(12, 73);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(298, 21);
            this.Locations.TabIndex = 5;
            this.Locations.SelectedIndexChanged += new System.EventHandler(this.Selection);
            // 
            // SaveMap
            // 
            this.SaveMap.Enabled = false;
            this.SaveMap.Location = new System.Drawing.Point(210, 45);
            this.SaveMap.Name = "SaveMap";
            this.SaveMap.Size = new System.Drawing.Size(100, 25);
            this.SaveMap.TabIndex = 7;
            this.SaveMap.Text = "Save Map";
            this.SaveMap.UseVisualStyleBackColor = true;
            this.SaveMap.Click += new System.EventHandler(this.SaveMap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Positions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sign:";
            // 
            // SignType
            // 
            this.SignType.AutoSize = true;
            this.SignType.Location = new System.Drawing.Point(46, 110);
            this.SignType.Name = "SignType";
            this.SignType.Size = new System.Drawing.Size(0, 13);
            this.SignType.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 641);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SignToolsGUI 001";
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
    }
}

