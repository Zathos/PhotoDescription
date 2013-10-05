using System.Data.Entity;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoDescription.EFEntities;
using PhotoDescription.Persistent;
using PhotoDescription.EFEntityFramework;

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

        [Test]
        public void PhotoContext_Photo()
        {
            using (var context = new PhotoContext())
            {
                var photos = context.Photos.Select(x => x.PhotoId).ToList();
                Assert.That(photos.Count, Is.GreaterThan(0));
            }
        }

        [TestFixtureSetUp]
        public void SetupOnce()
        {
            Database.SetInitializer(new PhotoTestsInitializer());
        }
    }

    internal class PhotoTestsInitializer : DropCreateDatabaseAlways<PhotoContext>
    {
        protected override void Seed(PhotoContext context)
        {
            var photo = new Photo
                            {
                                PhotoId = 123,
                            };
            context.Photos.Add(photo);
        }
    }
}
