using PhotoDescription.Persistent;

namespace PhotoDescription
{
    public class MainProcess
    {
        private readonly IPhotoRepository _photoRepository;

        public MainProcess(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }

        public void LoadNewPath(string selectedPath)
        {
            
            var temp = selectedPath.Split('\\');
            var rootDir = temp[temp.Length - 1];

            var photoListFromFileSys = _photoRepository.LoadPhotosFromFileSys(rootDir);
            _photoRepository.CreateNewDatabaseEntries(photoListFromFileSys);
        }
    }
}