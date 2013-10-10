using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using PhotoDescription.EFEntities;
using PhotoDescription.EFEntityFramework;

namespace PhotoDescription.Persistent
{
    public class PhotoRepository : IPhotoRepository
    {
        ///// <summary>
        ///// Updates the database.
        ///// </summary>
        ///// <param name="rootDir">The root dir.</param>
        ///// <returns></returns>
        //public IList<Photo> CreateNewDatabaseEntries(IList<Photo> rootDir)
        //{
        //    //TODO create new entries, don't change existing.
        //    using (var context = new PhotoContext())
        //    {
        //        var photos = context.Photos.Where(x => x.Root.CompareTo(rootDir) == 0).ToList();
        //        return photos;
        //    }
        //}

        /// <summary>
        /// Loads the photos from file system.
        /// </summary>
        /// <param name="tripId">The trip unique identifier.</param>
        /// <returns></returns>
        public IList<Photo> LoadPhotosByTripId(int tripId)
        {
            using (var context = new PhotoContext())
            {
                var photos = context.Photos.Where(x => x.TripId == tripId).ToList();
                return photos;
            }
        }

        public void CreateTrip(string path, string title, string description)
        {
            using (var context = new PhotoContext())
            {
                var trip = new Trip()
                               {
                                   Description = description,
                                   RootPath = path,
                                   TripName = title,
                               };
                context.Trips.Add(trip);

                context.SaveChanges();
            }
        }

        public void CreatePhotos(IList<Photo> photos)
        {
            using (var context = new PhotoContext())
            {
                foreach (var photo in photos)
                {
                    context.Photos.Add(photo);   
                }
                context.SaveChanges();
            }
        }

        public IList<Trip> LoadAllTrips()
        {
            using (var context = new PhotoContext())
            {
                var trips = from t in context.Trips
                            select t;
                return trips.ToList();
            }
        }

        public Trip LoadTripWithName(string title)
        {
            using (var context = new PhotoContext())
            {
                var data = from t in context.Trips
                           where t.TripName == title
                           select t;
                var trip = data.ToList();

                switch (trip.Count)
                {
                    case 0:
                        return new Trip{TripId = 0};
                    case 1:
                        return trip[0];
                    default:
                        //should never hit this case, but if I don't the exception will be epic.
                        return null;
                }
            }
        }
    }
}