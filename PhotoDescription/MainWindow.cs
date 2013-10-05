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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureDisplay.ImageLocation = "C:\\Users\\Zathos\\Downloads\\PicTaggingTest\\1\\PICT0001.JPG";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    }
}
