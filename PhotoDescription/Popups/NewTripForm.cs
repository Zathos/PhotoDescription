using System;
using System.IO;
using System.Windows.Forms;

namespace PhotoDescription.Popups
{
    public partial class NewTripForm : Form
    {
        public NewTripForm()
        {
            InitializeComponent();
        }

        public string Description
        {
            get { return TripDescription.Text; }
        }

        public string Path
        {
            get { return PathText.Text; }
        }

        public string Title
        {
            get { return TripTitleText.Text; }
        }

        private int CountPictures(string fullPath)
        {
            var totalCount = Directory.GetFiles(fullPath, "*.jpg", SearchOption.AllDirectories).Length;
            totalCount += Directory.GetFiles(fullPath, "*.png", SearchOption.AllDirectories).Length;
            return totalCount;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PathPickerButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                PathText.Text = folderBrowserDialog1.SelectedPath;

                var fullPath = folderBrowserDialog1.SelectedPath;
                var temp = fullPath.Split('\\');
                var lastDir = temp[temp.Length - 1];

                TripTitleText.Text = lastDir;

                PictureCountLabel.Text = CountPictures(fullPath).ToString();
            }
        }
    }
}