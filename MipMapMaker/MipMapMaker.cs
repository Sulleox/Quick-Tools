using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MipMapMaker
{
	public partial class MipMapMaker : Form
	{
		public MipMapMaker()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = folderBrowserDialog.SelectedPath;
                GetFilesInFolder();
            }
        }

        private void GetFilesInFolder()
        {
            
        }
    }
}
