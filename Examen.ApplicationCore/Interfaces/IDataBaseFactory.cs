using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.ApplicationCore.Interfaces
{
   public interface IDataBaseFactory : IDisposable
    {
        DbContext DataContext { get; }
    }
}
