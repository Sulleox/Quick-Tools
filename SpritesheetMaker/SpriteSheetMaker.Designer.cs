namespace SpritesheetMaker
{
	partial class SpritesheetMaker
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.BrowsingButton = new System.Windows.Forms.Button();
            this.SpritesFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.spritepathBox = new System.Windows.Forms.TextBox();
            this.extensionBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BrowsingButton
            // 
            this.BrowsingButton.Location = new System.Drawing.Point(12, 12);
            this.BrowsingButton.Name = "BrowsingButton";
            this.BrowsingButton.Size = new System.Drawing.Size(75, 23);
            this.BrowsingButton.TabIndex = 0;
            this.BrowsingButton.Text = "Browse";
            this.BrowsingButton.UseVisualStyleBackColor = true;
            this.BrowsingButton.Click += new System.EventHandler(this.BrowsingButton_Click);
            // 
            // spritepathBox
            // 
            this.spritepathBox.Location = new System.Drawing.Point(12, 53);
            this.spritepathBox.Name = "spritepathBox";
            this.spritepathBox.Size = new System.Drawing.Size(201, 20);
            this.spritepathBox.TabIndex = 1;
            // 
            // extensionBox
            // 
            this.extensionBox.FormattingEnabled = true;
            this.extensionBox.Items.AddRange(new object[] {
            "png",
            "bmp"});
            this.extensionBox.Location = new System.Drawing.Point(153, 79);
            this.extensionBox.Name = "extensionBox";
            this.extensionBox.Size = new System.Drawing.Size(60, 21);
            this.extensionBox.TabIndex = 2;
            this.extensionBox.Text = "png";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 79);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 20);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "SpriteSheetName";
            // 
            // SpritesheetMaker
            // 
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.extensionBox);
            this.Controls.Add(this.spritepathBox);
            this.Controls.Add(this.BrowsingButton);
            this.Name = "SpritesheetMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button BrowsingButton;
        private System.Windows.Forms.FolderBrowserDialog SpritesFolderBrowser;
        private System.Windows.Forms.TextBox spritepathBox;
        private System.Windows.Forms.ComboBox extensionBox;
        private System.Windows.Forms.TextBox nameBox;
    }
}

