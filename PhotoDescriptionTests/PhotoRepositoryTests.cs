using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoDescription.Persistent;

namespace PhotoDescriptionTests
{
    class PhotoRepositoryTests
    {
        [Test]
        public void PhotoContext_Constructor()
        {
            var context = new PhotoRepository();
            Assert.That(context, Is.Not.Null);
        }
    }
}
