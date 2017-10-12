namespace ImageResizer
{
    partial class ImageResizer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageResizer));
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.ImageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.heigthInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.overwriteToggle = new System.Windows.Forms.CheckBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.buttonResize = new System.Windows.Forms.Button();
            this.widthCombo = new System.Windows.Forms.ComboBox();
            this.heightCombo = new System.Windows.Forms.ComboBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heigthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(12, 96);
            this.widthInput.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(106, 20);
            this.widthInput.TabIndex = 1;
            this.widthInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // heigthInput
            // 
            this.heigthInput.Location = new System.Drawing.Point(124, 96);
            this.heigthInput.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.heigthInput.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.heigthInput.Name = "heigthInput";
            this.heigthInput.Size = new System.Drawing.Size(107, 20);
            this.heigthInput.TabIndex = 2;
            this.heigthInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Heigth";
            // 
            // overwriteToggle
            // 
            this.overwriteToggle.AutoSize = true;
            this.overwriteToggle.Location = new System.Drawing.Point(12, 160);
            this.overwriteToggle.Name = "overwriteToggle";
            this.overwriteToggle.Size = new System.Drawing.Size(108, 17);
            this.overwriteToggle.TabIndex = 5;
            this.overwriteToggle.Text = "Overwrite Images";
            this.overwriteToggle.UseVisualStyleBackColor = true;
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(15, 51);
            this.pathBox.Multiline = true;
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(216, 20);
            this.pathBox.TabIndex = 6;
            // 
            // buttonResize
            // 
            this.buttonResize.Location = new System.Drawing.Point(156, 154);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(75, 23);
            this.buttonResize.TabIndex = 7;
            this.buttonResize.Text = "Resize";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // widthCombo
            // 
            this.widthCombo.FormattingEnabled = true;
            this.widthCombo.Items.AddRange(new object[] {
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096"});
            this.widthCombo.Location = new System.Drawing.Point(12, 122);
            this.widthCombo.Name = "widthCombo";
            this.widthCombo.Size = new System.Drawing.Size(106, 21);
            this.widthCombo.TabIndex = 8;
            this.widthCombo.Text = "16";
            this.widthCombo.SelectedIndexChanged += new System.EventHandler(this.widthCombo_SelectedIndexChanged);
            // 
            // heightCombo
            // 
            this.heightCombo.FormattingEnabled = true;
            this.heightCombo.Items.AddRange(new object[] {
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096"});
            this.heightCombo.Location = new System.Drawing.Point(123, 122);
            this.heightCombo.Name = "heightCombo";
            this.heightCombo.Size = new System.Drawing.Size(108, 21);
            this.heightCombo.TabIndex = 9;
            this.heightCombo.Text = "16";
            this.heightCombo.SelectedIndexChanged += new System.EventHandler(this.heightCombo_SelectedIndexChanged);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ImageResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 188);
            this.Controls.Add(this.heightCombo);
            this.Controls.Add(this.widthCombo);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.overwriteToggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heigthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.buttonBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageResizer";
            this.Text = "Image Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heigthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FolderBrowserDialog ImageFolderBrowser;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.NumericUpDown heigthInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox overwriteToggle;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.ComboBox widthCombo;
        private System.Windows.Forms.ComboBox heightCombo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

