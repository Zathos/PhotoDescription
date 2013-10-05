using System.Collections.Generic;
using System.Linq;
using PhotoDescription.EFEntities;
using PhotoDescription.EFEntityFramework;

namespace PhotoDescription.Persistent
{
    internal class PhotoRepository : IPhotoRepository
    {
        /// <summary>
        /// Updates the database.
        /// </summary>
        /// <param name="rootDir">The root dir.</param>
        /// <returns></returns>
        public IList<Photo> CreateNewDatabaseEntries(IList<Photo> rootDir)
        {
            //TODO create new entries, don't change existing.
            using (var context = new PhotoContext())
            {
                var photos = context.Photos.Where(x => x.Root.CompareTo(rootDir) == 0).ToList();
                return photos;
            }
        }

        /// <summary>
        /// Loads the photos from file system.
        /// </summary>
        /// <param name="rootDir">The root dir.</param>
        /// <returns></returns>
        public IList<Photo> LoadPhotosFromFileSys(string rootDir)
        {
            //TODO load photos from root dir, include sub dirs.
            return null;
        }
    }
}