using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoodleProject.DataLibrary.Data
{
    class CoreContext: DbContext
    {
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Threads> Threads { get; set; }

        public CoreContext():base ("CoreContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
