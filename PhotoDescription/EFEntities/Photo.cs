using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoDescription.EFEntities
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public string FullPath { get; set; }
        public string Description { get; set; }
        public string Root { get; set; }
    }
}
