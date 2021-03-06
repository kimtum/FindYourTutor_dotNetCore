﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FYT.DataAccess.Data.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        void Save();
    }
}
