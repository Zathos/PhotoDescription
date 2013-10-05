﻿using System.Collections.Generic;
using PhotoDescription.EFEntities;

namespace PhotoDescription.Persistent
{
    public interface IPhotoRepository
    {
        IList<Photo> CreateNewDatabaseEntries(IList<Photo> rootDir);
        IList<Photo> LoadPhotosFromFileSys(string rootDir);
    }
}