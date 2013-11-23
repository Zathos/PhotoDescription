using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoDescription.EFEntities;

namespace PhotoDescription.Persistent
{
    class XMLPhotoRepository : IPhotoRepository
    {

        public IList<Photo> LoadPhotosByTripId(int tripId)
        {
            return null;
        }

        public void CreateTrip(string path, string title, string description)
        {
        }

        public void CreatePhotos(IList<Photo> photos)
        {
        }

        public IList<Trip> LoadAllTrips()
        {
            return null;
        }

        public Trip LoadTripWithName(string title)
        {
            return null;
        }

        public void UpdatePhoto(Photo photo)
        {
        }
    }
}
