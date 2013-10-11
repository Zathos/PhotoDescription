using System.Collections.Generic;
using PhotoDescription.EFEntities;

namespace PhotoDescription.Persistent
{
    public interface IPhotoRepository
    {
        //IList<Photo> CreateNewDatabaseEntries(IList<Photo> rootDir);
        IList<Photo> LoadPhotosByTripId(int tripId);
        void CreateTrip(string path, string title, string description);
        void CreatePhotos(IList<Photo> photos);
        IList<Trip> LoadAllTrips();
        Trip LoadTripWithName(string title);

        void UpdatePhotos(IList<Photo> photos);
    }
}