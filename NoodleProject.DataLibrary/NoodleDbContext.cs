using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoodleProject.DataLibrary
{
    class NoodleDbContext: DbContext
    {
        public DbSet<Threads> Threads { get; set; }
        public DbSet<Posts> Posts { get; set; }

        public NoodleDbContext() : base("NoodleDbContext")
        {

        }

        public static NoodleDbContext Create()
        {
            return new NoodleDbContext();
        }
    }
}
