using System.Data.Entity;
using PhotoDescription.EFEntities;

namespace PhotoDescription.EFEntityFramework
{
    public class PhotoContext : DbContext
    {
        public IDbSet<Photo> Photos { get; set; }
        public IDbSet<Trip> Trips { get; set; }

        //TODO may need to add in mapping but for now just let it ride.
    }
}