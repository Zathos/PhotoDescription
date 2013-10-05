using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDescription.EFEntities
{
    class Trip
    {
        public int TripId { get; set; }
        public string Description { get; set; }
        public string RootPath { get; set; }
    }
}
