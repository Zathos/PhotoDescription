using System.Collections.Generic;
using PhotoDescription.EFEntities;
using PhotoDescription.Persistent;
using PhotoDescription.Popups;

namespace PhotoDescription
{
    public class MainProcess
    {
        public MainProcess(IPhotoRepository photoRepository, NewTripForm newTripFrom)
        {
            _photoRepository = photoRepository;
            _newTripFrom = newTripFrom;
        }

        //public void CreateTrip(MainWindow mainWindow)
        public void CreateTrip()
        {
            _newTripFrom.ShowDialog();
            
        }

        public void LoadNewPath(string selectedPath)
        {
            var temp = selectedPath.Split('\\');
            var rootDir = temp[temp.Length - 1];

            //var photoListFromFileSys = _photoRepository.LoadPhotosFromFileSys(rootDir);
            //_photoRepository.CreateNewDatabaseEntries(photoListFromFileSys);
        }

        private readonly NewTripForm _newTripFrom;
        private readonly IPhotoRepository _photoRepository;

        public void AddTripData(string path, string title, string description)
        {
            _photoRepository.CreateTrip(path, title, description);

            IList<Photo> photos = LoadPicturesFromFilesSystem(path);

            _photoRepository.CreatePhotos(photos);
        }

        private IList<Photo> LoadPicturesFromFilesSystem(string path)
        {
            return null;
        }
    }
}