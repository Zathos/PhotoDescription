using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PhotoDescription.EFEntities;
using PhotoDescription.View;

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

            PictureIndex.KeyPress += new KeyPressEventHandler(PictureIndex_KeyPress);
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            var photo = _tripData.NextPhoto;
            UpdateDisplay(photo);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            var photo = _tripData.PreviousPhoto;
            UpdateDisplay(photo);
        }

        private void UpdateDisplay(Photo photo)
        {
            PhotoDisplay.ImageLocation = photo.FullPath;
            PhotoPath.Text = photo.FullPath;
            PhotoDescription.Text = photo.Description;
            PhotoCount.Text = _tripData.DisplayPhotoCount;
            PictureIndex.Text = (_tripData.CurrentPhotoIndex + 1).ToString();
        }

        private void TripClicked_Event(object sender, EventArgs e)
        {
            var tripMenuItem = (ToolStripMenuItem) sender;
            _tripData = _process.LoadTrip(tripMenuItem.Text);
            PreviousButton_Click(null, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _process.SaveLoadedTrip(_tripData);
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
            var tripName = _process.CreateTrip();
            if (tripName != null)
            {
                _tripData = _process.LoadTrip(tripName);
                PreviousButton_Click(null, null);
            }
        }

        private readonly MainProcess _process;
        private TripData _tripData;

        private void PictureIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_tripData != null && e.KeyChar == '\r')
            {
                var photo = _tripData.MoveToPhoto(int.Parse(PictureIndex.Text));
                UpdateDisplay(photo);
            }
        }

    }
}