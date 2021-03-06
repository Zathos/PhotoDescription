﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using PhotoDescription.EFEntities;
using PhotoDescription.Persistent;
using PhotoDescription.Popups;
using PhotoDescription.View;

namespace PhotoDescription
{
    public class MainProcess
    {
        public MainProcess(IPhotoRepository photoRepository, NewTripForm newTripFrom)
        {
            _photoRepository = photoRepository;
            _newTripFrom = newTripFrom;
        }

        public void AddTripData(string path, string title, string description)
        {
            var tripExsitsCheck = _photoRepository.LoadTripWithName(title);
            if (tripExsitsCheck.TripId != 0)
            {
                //Trip has already been created.
                return;
            }

            _photoRepository.CreateTrip(path, title, description);
            var newTrip = _photoRepository.LoadTripWithName(title);

            var photos = LoadPicturesFromFilesSystem(path, newTrip.TripId);

            _photoRepository.CreatePhotos(photos);
        }

        public IList<string> AvailableTrips()
        {
            //TODO fix side affect programming...
            _availableTrips = _photoRepository.LoadAllTrips();
            return _availableTrips.Select(x => x.TripName).ToList();
        }

        public void Backup(TripData tripData)
        {
            const string BackupDir = ".\\Backup\\";
            if (!Directory.Exists(BackupDir))
            {
                Directory.CreateDirectory(BackupDir);
            }

            var mySerializer = new XmlSerializer(typeof(TripData));
            var myWriter = new StreamWriter(BackupDir + tripData.Trip.TripName + "." + DateTime.Now.ToFileTime() + ".xml");

            mySerializer.Serialize(myWriter, tripData);
            myWriter.Close();

        }

        public string CreateTrip()
        {
            if (_newTripFrom.ShowDialog() == DialogResult.OK)
            {
                AddTripData(_newTripFrom.Path, _newTripFrom.Title, _newTripFrom.Description);
                AvailableTrips();
                return _newTripFrom.Title;
            }
            return null;
        }

        public void LoadNewPath(string selectedPath)
        {
            var temp = selectedPath.Split('\\');
            var rootDir = temp[temp.Length - 1];

            //var photoListFromFileSys = _photoRepository.LoadPhotosFromFileSys(rootDir);
            //_photoRepository.CreateNewDatabaseEntries(photoListFromFileSys);
        }

        public TripData LoadTrip(string tripName)
        {
            var trip = _availableTrips.FirstOrDefault(x => x.TripName == tripName);
            if (trip != null)
            {
                var photos = _photoRepository.LoadPhotosByTripId(trip.TripId);
                return new TripData(trip, photos);
            }
            return null;
        }

        private IList<Photo> LoadPicturesFromFilesSystem(string path, int tripId)
        {
            var fileList = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            return fileList.Where(x => x.EndsWith(".jpg") || x.EndsWith(".png") || x.EndsWith(".JPG") || x.EndsWith(".PNG"))
                           .Select(s => new Photo
                                            {
                                                FullPath = s,
                                                TripId = tripId,
                                            }).ToList();
        }

        public void SaveLoadedTrip(TripData tripData)
        {
            SavePhoto(tripData.CurrentPhoto);
        }

        private readonly NewTripForm _newTripFrom;
        private readonly IPhotoRepository _photoRepository;
        private IList<Trip> _availableTrips;

        public void SavePhoto(Photo photo)
        {
            _photoRepository.UpdatePhoto(photo);
        }
    }
}