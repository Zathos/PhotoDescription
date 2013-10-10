using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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
            _photoRepository.CreateTrip(path, title, description);
            var newTrip = _photoRepository.LoadTripWithName(title);

            IList<Photo> photos = LoadPicturesFromFilesSystem(path, newTrip.TripId);

            _photoRepository.CreatePhotos(photos);
        }

        public IList<string> AvailableTrips()
        {
            //TODO fix side affect programming smell...
            _availableTrips = _photoRepository.LoadAllTrips();
            return _availableTrips.Select(x => x.TripName).ToList();
        }

        public void Backup()
        {
            //TODO should be able to just dump TripData?
        }

        public void CreateTrip()
        {
            if (_newTripFrom.ShowDialog() == DialogResult.OK)
            {
                AddTripData(_newTripFrom.Path, _newTripFrom.Title, _newTripFrom.Description);
            }
        }

        public void LoadNewPath(string selectedPath)
        {
            var temp = selectedPath.Split('\\');
            var rootDir = temp[temp.Length - 1];

            //var photoListFromFileSys = _photoRepository.LoadPhotosFromFileSys(rootDir);
            //_photoRepository.CreateNewDatabaseEntries(photoListFromFileSys);
        }

        public void LoadTrip(string tripName)
        {
            //TODO make sure to save if there is already a trip loaded.
            SaveLoadedTrip();

            //TODO load based on this.
            var trip = _availableTrips.FirstOrDefault(x => x.TripName == tripName);
            if (trip != null)
            {
                var photos = _photoRepository.LoadPhotosByTripId(trip.TripId);
                _tripData = new TripData(trip, photos);
            }
        }

        private void SaveLoadedTrip()
        {

        }
        
        private IList<Photo> LoadPicturesFromFilesSystem(string path, int tripId)
        {
            var fileList = Directory.GetFiles(path);
            return fileList.Select(s => new Photo
                                            {
                                                FullPath = path + "\\" + s,
                                                TripId = tripId,
                                            }).ToList();
        }

        private readonly NewTripForm _newTripFrom;
        private readonly IPhotoRepository _photoRepository;
        private TripData _tripData;
        private IList<Trip> _availableTrips;

        internal Photo GetPreviousPhoto()
        {
            return _tripData.GetPreviousPhoto;
        }

        internal Photo GetNextPhoto()
        {
            return _tripData.GetNextPhoto;
        }
    }
}