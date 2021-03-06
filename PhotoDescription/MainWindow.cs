﻿using System;
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

            PictureIndex.KeyPress += PictureIndex_KeyPress;
        }

        private void SaveCurrentlyLoadedTrip()
        {
            if (_tripData != null)
            {
                _process.SaveLoadedTrip(_tripData);
            }
        }


        private void UpdateDescription()
        {
            var photo = _tripData.UpdateDescription(PhotoDescription.Text);
            _process.SavePhoto(photo);
        }

        private void UpdateDisplay(Photo photo)
        {
            PhotoDisplay.ImageLocation = photo.FullPath;
            PhotoPath.Text = photo.FullPath;
            PhotoDescription.Text = photo.Description;
            PhotoCount.Text = _tripData.DisplayPhotoCount;
            PictureIndex.Text = (_tripData.CurrentPhotoIndex + 1).ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            UpdateDescription();
            var photo = _tripData.NextPhoto;
            UpdateDisplay(photo);
        }

        private void PictureIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_tripData != null && e.KeyChar == '\r')
            {
                var photo = _tripData.MoveToPhoto(int.Parse(PictureIndex.Text));
                UpdateDisplay(photo);
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            UpdateDescription();
            var photo = _tripData.PreviousPhoto;
            UpdateDisplay(photo);
        }

        private void TripClicked_Event(object sender, EventArgs e)
        {
            SaveCurrentlyLoadedTrip();

            var tripMenuItem = (ToolStripMenuItem) sender;
            _tripData = _process.LoadTrip(tripMenuItem.Text);
            UpdateDisplay(_tripData.CurrentPhoto);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_tripData != null)
            {
                UpdateDescription();
                SaveCurrentlyLoadedTrip();
                _process.Backup(_tripData);
            }

            Environment.Exit(0);
        }

        private void newTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCurrentlyLoadedTrip();

            var tripName = _process.CreateTrip();
            if (tripName != null)
            {
                _tripData = _process.LoadTrip(tripName);
                UpdateDisplay(_tripData.CurrentPhoto);
            }
        }

        private readonly MainProcess _process;
        private TripData _tripData;

        private void ExitButton_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(null, null);
        }
    }
}