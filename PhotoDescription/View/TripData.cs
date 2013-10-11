using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using PhotoDescription.EFEntities;

namespace PhotoDescription.View
{
    public class TripData
    {
        public TripData()
        {
        }

        public TripData(Trip trip, IList<Photo> photos)
        {
            Trip = trip;
            Photos = photos as List<Photo>;
            CurrentPhotoIndex = 0;
        }

        [XmlIgnore]
        public Photo CurrentPhoto
        {
            get { return Photos[CurrentPhotoIndex]; }
        }

        [XmlIgnore]
        public int CurrentPhotoIndex { get; private set; }

        [XmlIgnore]
        public string DisplayPhotoCount
        {
            get { return string.Format("{0}/{1}", CurrentPhotoIndex + 1, Photos.Count); }
        }

        [XmlIgnore]
        public Photo NextPhoto
        {
            get
            {
                CurrentPhotoIndex += 1;
                if (CurrentPhotoIndex >= Photos.Count())
                {
                    CurrentPhotoIndex -= 1;
                }
                return CurrentPhoto;
            }
        }

        public List<Photo> Photos { get; set; }

        [XmlIgnore]
        public Photo PreviousPhoto
        {
            get
            {
                CurrentPhotoIndex -= 1;
                if (CurrentPhotoIndex < 0)
                {
                    CurrentPhotoIndex = 0;
                }
                return CurrentPhoto;
            }
        }

        public Trip Trip { get; set; }

        public Photo MoveToPhoto(int photoNumber)
        {
            var index = photoNumber - 1;
            CurrentPhotoIndex = index >= 0 && index < Photos.Count ? index : CurrentPhotoIndex;
            return CurrentPhoto;
        }

        public Photo UpdateDescription(string newDescription)
        {
            CurrentPhoto.Description = newDescription;
            return CurrentPhoto;
        }
    }
}