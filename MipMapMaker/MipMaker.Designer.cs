namespace MipMapMaker
{
	partial class MipMaker
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
			this.browseButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.pathBox = new System.Windows.Forms.TextBox();
			this.confirmButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point( 12, 12 );
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size( 75, 23 );
			this.browseButton.TabIndex = 0;
			this.browseButton.Text = "Browse...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler( this.button1_Click );
			// 
			// pathBox
			// 
			this.pathBox.Location = new System.Drawing.Point( 11, 41 );
			this.pathBox.Name = "pathBox";
			this.pathBox.Size = new System.Drawing.Size( 208, 20 );
			this.pathBox.TabIndex = 1;
			// 
			// confirmButton
			// 
			this.confirmButton.Location = new System.Drawing.Point( 144, 67 );
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size( 75, 23 );
			this.confirmButton.TabIndex = 2;
			this.confirmButton.Text = "Convert";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler( this.confirmButton_Click );
			// 
			// MipMakerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 235, 106 );
			this.Controls.Add( this.confirmButton );
			this.Controls.Add( this.pathBox );
			this.Controls.Add( this.browseButton );
			this.Name = "MipMakerForm";
			this.Text = "MipMap Packer";
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox pathBox;
		private System.Windows.Forms.Button confirmButton;
	}
}