using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Trip Trip { get; private set; }
        public IList<Photo> Photos { get; private set; }

        public int CurrentPhotoIndex { get; private set; }

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

        public string DisplayPhotoCount
        {
            get
            {
                return string.Format("{0}/{1}", CurrentPhotoIndex + 1, Photos.Count);
            }
        }

        public Photo MoveToPhoto(int photoNumber)
        {
            var index = photoNumber - 1;
            CurrentPhotoIndex = index >= 0 && index < Photos.Count ? index : CurrentPhotoIndex;
            return Photos[CurrentPhotoIndex];
        }
    }
}
