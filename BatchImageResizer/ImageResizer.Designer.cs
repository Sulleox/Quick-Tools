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
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.ImageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.heigthInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.overwriteToggle = new System.Windows.Forms.CheckBox();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.buttonResize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heigthInput)).BeginInit();
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
            this.widthInput.Size = new System.Drawing.Size(53, 20);
            this.widthInput.TabIndex = 1;
            this.widthInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // heigthInput
            // 
            this.heigthInput.Location = new System.Drawing.Point(71, 96);
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
            this.heigthInput.Size = new System.Drawing.Size(49, 20);
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
            this.label2.Location = new System.Drawing.Point(71, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Heigth";
            // 
            // overwriteToggle
            // 
            this.overwriteToggle.AutoSize = true;
            this.overwriteToggle.Location = new System.Drawing.Point(12, 137);
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
            this.pathBox.Size = new System.Drawing.Size(199, 20);
            this.pathBox.TabIndex = 6;
            // 
            // buttonResize
            // 
            this.buttonResize.Location = new System.Drawing.Point(139, 137);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(75, 23);
            this.buttonResize.TabIndex = 7;
            this.buttonResize.Text = "Resize";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // ImageResizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.overwriteToggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heigthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "ImageResizer";
            this.Text = "Image Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heigthInput)).EndInit();
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
    }
}

