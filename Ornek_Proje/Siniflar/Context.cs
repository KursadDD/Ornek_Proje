using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ornek_Proje.Siniflar
{
    public class Context: DbContext
    {
        public DbSet<Kisiler> Kisilers { get; set; }
        public DbSet<Bolum> Bolums { get; set; }
    }
}