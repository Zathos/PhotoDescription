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
            CurrentPhoto = 0;
        }

        public Trip Trip { get; private set; }
        public IList<Photo> Photos { get; private set; }

        private int CurrentPhoto { get; set; }

        public Photo GetNextPhoto
        {
            get
            {
                CurrentPhoto += 1;
                if (CurrentPhoto >= Photos.Count())
                {
                    CurrentPhoto -= 1;
                }
                return Photos[CurrentPhoto];
            }
        }

        public Photo GetPreviousPhoto
        {
            get
            {
                CurrentPhoto -= 1;
                if (CurrentPhoto < 0)
                {
                    CurrentPhoto = 0;
                }
                return Photos[CurrentPhoto];
            }
        }

    }
}
