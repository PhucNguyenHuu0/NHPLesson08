using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NHPLesson08.Models
{
    public class NhpBookStore: DbContext
    { public NhpBookStore() : base()
        {

        }
        // tao cac bang
        public DbSet<NhpCategory> NhpCategories { get; set; }
        public DbSet<NhpBook> NhpBooks { get; set; }

    }
}