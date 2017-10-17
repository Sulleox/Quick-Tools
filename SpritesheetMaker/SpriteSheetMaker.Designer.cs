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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpritesheetMaker));
            this.BrowsingButton = new System.Windows.Forms.Button();
            this.SpritesFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.spritepathBox = new System.Windows.Forms.TextBox();
            this.extensionBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.overwriteBox = new System.Windows.Forms.CheckBox();
            this.outpoutPathBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outpoutFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oneFolderCheck = new System.Windows.Forms.CheckBox();
            this.oneFolderTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BrowsingButton
            // 
            this.BrowsingButton.Location = new System.Drawing.Point(138, 15);
            this.BrowsingButton.Name = "BrowsingButton";
            this.BrowsingButton.Size = new System.Drawing.Size(75, 23);
            this.BrowsingButton.TabIndex = 0;
            this.BrowsingButton.Text = "Browse";
            this.BrowsingButton.UseVisualStyleBackColor = true;
            this.BrowsingButton.Click += new System.EventHandler(this.BrowsingButton_Click);
            // 
            // spritepathBox
            // 
            this.spritepathBox.Location = new System.Drawing.Point(12, 44);
            this.spritepathBox.Name = "spritepathBox";
            this.spritepathBox.Size = new System.Drawing.Size(201, 20);
            this.spritepathBox.TabIndex = 1;
            // 
            // extensionBox
            // 
            this.extensionBox.FormattingEnabled = true;
            this.extensionBox.Items.AddRange(new object[] {
            "png",
            "bmp",
            "jpg"});
            this.extensionBox.Location = new System.Drawing.Point(153, 70);
            this.extensionBox.Name = "extensionBox";
            this.extensionBox.Size = new System.Drawing.Size(60, 21);
            this.extensionBox.TabIndex = 2;
            this.extensionBox.Text = "png";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 70);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(135, 20);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "SpriteSheetName";
            // 
            // overwriteBox
            // 
            this.overwriteBox.AutoSize = true;
            this.overwriteBox.Location = new System.Drawing.Point(12, 171);
            this.overwriteBox.Name = "overwriteBox";
            this.overwriteBox.Size = new System.Drawing.Size(71, 17);
            this.overwriteBox.TabIndex = 4;
            this.overwriteBox.Text = "Overwrite";
            this.oneFolderTooltip.SetToolTip(this.overwriteBox, "Force overwrite if spritesheets already exist");
            this.overwriteBox.UseVisualStyleBackColor = true;
            // 
            // outpoutPathBox
            // 
            this.outpoutPathBox.Location = new System.Drawing.Point(12, 145);
            this.outpoutPathBox.Name = "outpoutPathBox";
            this.outpoutPathBox.Size = new System.Drawing.Size(201, 20);
            this.outpoutPathBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(138, 191);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create !";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Sprites Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Outpout Folder";
            // 
            // oneFolderCheck
            // 
            this.oneFolderCheck.AutoSize = true;
            this.oneFolderCheck.Location = new System.Drawing.Point(12, 191);
            this.oneFolderCheck.Name = "oneFolderCheck";
            this.oneFolderCheck.Size = new System.Drawing.Size(78, 17);
            this.oneFolderCheck.TabIndex = 10;
            this.oneFolderCheck.Text = "One Folder";
            this.oneFolderTooltip.SetToolTip(this.oneFolderCheck, "If the folder contains multiple spritesheets");
            this.oneFolderCheck.UseVisualStyleBackColor = true;
            this.oneFolderCheck.CheckedChanged += new System.EventHandler(this.oneFolderCheck_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(0, 211);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(24, 12);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "v1.0";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SpritesheetMaker
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(223, 226);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.oneFolderCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outpoutPathBox);
            this.Controls.Add(this.overwriteBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.extensionBox);
            this.Controls.Add(this.spritepathBox);
            this.Controls.Add(this.BrowsingButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpritesheetMaker";
            this.Text = "SpriteSheet Maker";
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
        private System.Windows.Forms.CheckBox overwriteBox;
        private System.Windows.Forms.TextBox outpoutPathBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog outpoutFolderDialog;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox oneFolderCheck;
		private System.Windows.Forms.ToolTip oneFolderTooltip;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

