using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDescription
{
    public partial class MainWindow : Form
    {
        private readonly MainProcess _process;

        public MainWindow(MainProcess process)
        {
            _process = process;
            InitializeComponent();

            //TODO will probably need to set up some binding.
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO display path picker
            var results = folderBrowserDialog1.ShowDialog();
            if (results == DialogResult.OK)
            {
                _process.LoadNewPath(folderBrowserDialog1.SelectedPath);

                //PictureDisplay.ImageLocation = "C:\\Users\\Zathos\\Downloads\\PicTaggingTest\\1\\PICT0001.JPG";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}
