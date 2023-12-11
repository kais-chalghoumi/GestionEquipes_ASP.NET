using Examen.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.ApplicationCore.Services
{
    public class DataBaseFactory : Disposable, IDataBaseFactory
    {
        private DbContext dataContext;
        public DbContext DataContext
        {
            get { return dataContext; }
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}

