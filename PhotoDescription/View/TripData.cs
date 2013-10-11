using System.Collections.Generic;
using System.Linq;
using PhotoDescription.EFEntities;

namespace PhotoDescription.View
{
    public class TripData
    {
        public TripData(Trip trip, IList<Photo> photos)
        {
            Trip = trip;
            Photos = photos;
            CurrentPhotoIndex = 0;
        }

        public int CurrentPhotoIndex { get; private set; }

        public string DisplayPhotoCount
        {
            get { return string.Format("{0}/{1}", CurrentPhotoIndex + 1, Photos.Count); }
        }

        public Photo NextPhoto
        {
            get
            {
                CurrentPhotoIndex += 1;
                if (CurrentPhotoIndex >= Photos.Count())
                {
                    CurrentPhotoIndex -= 1;
                }
                return Photos[CurrentPhotoIndex];
            }
        }

        public IList<Photo> Photos { get; private set; }

        public Photo PreviousPhoto
        {
            get
            {
                CurrentPhotoIndex -= 1;
                if (CurrentPhotoIndex < 0)
                {
                    CurrentPhotoIndex = 0;
                }
                return Photos[CurrentPhotoIndex];
            }
        }

        public Trip Trip { get; private set; }

        public Photo MoveToPhoto(int photoNumber)
        {
            var index = photoNumber - 1;
            CurrentPhotoIndex = index >= 0 && index < Photos.Count ? index : CurrentPhotoIndex;
            return Photos[CurrentPhotoIndex];
        }

        public Photo UpdateDescription(string newDescription)
        {
            Photos[CurrentPhotoIndex].Description = newDescription;
            return Photos[CurrentPhotoIndex];
        }
    }
}