using EFwebLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Library
{
   public class context : DbContext
    {
        public context(DbContextOptions options) : base(options) { }

        public object StudentModelEF { get; internal set; }
        public DbSet<EFmodel> Staff
        {
            get;
            set;
        }
    }
}
