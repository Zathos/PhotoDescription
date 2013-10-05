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

        private int CountPictures(string fullPath)
        {
            var totalCount = Directory.GetFiles(fullPath, "*.jpg", SearchOption.AllDirectories).Length;
            totalCount += Directory.GetFiles(fullPath, "*.png", SearchOption.AllDirectories).Length;
            return totalCount;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //TODO START HERE chicken and the egg, I think fire an event from here, and main process will watch for it.
            //_mainProcess.AddTripData(PathText.Text, TripTitleText.Text, TripDescription.Text);
        }

        private void PathPickerButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
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