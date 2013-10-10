using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhotoDescription
{
    public partial class MainWindow : Form
    {
        public MainWindow(MainProcess process)
        {
            _process = process;
            InitializeComponent();

            IList<string> trips = _process.AvailableTrips();
            foreach (var trip in trips)
            {
                //TODO make this a new method
                var menuItem = new ToolStripMenuItem
                                   {
                                       Text = trip,
                                       Name = trip + "ToolStripMenuItem",
                                   };

                menuItem.Click += TripClicked_Event;

                recentToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }

        private void TripClicked_Event(object sender, EventArgs e)
        {
            var tripMenuItem = (ToolStripMenuItem) sender;
            _process.LoadTrip(tripMenuItem.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO save any changes to DB and export an XML backup.
            _process.Backup();
            Environment.Exit(0);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO testing... can be removed
            //PictureDisplay.ImageLocation = "C:\\Users\\dboershel\\Pictures\\Dominion\\13-03-22.png";
            //PictureDisplay.ImageLocation = "C:\\Users\\Zathos\\Downloads\\PicTaggingTest\\1\\PICT0001.JPG";
            //return;

            //var results = folderBrowserDialog1.ShowDialog();
            //if (results == DialogResult.OK)
            //{
            //    _process.LoadNewPath(folderBrowserDialog1.SelectedPath);
            //}
        }

        private void newTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _process.CreateTrip();
        }

        private readonly MainProcess _process;

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            var photo = _process.GetPreviousPhoto();
            PictureDisplay.ImageLocation = photo.FullPath;
            //TODO display this bad boy...
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var photo = _process.GetNextPhoto();
            PictureDisplay.ImageLocation = photo.FullPath;
            //TODO display this bad boy...
        }
    }
}