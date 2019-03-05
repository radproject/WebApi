using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoodleProject.DataLibrary.Data
{
    class ContextInitializer: DropCreateDatabaseIfModelChanges<BusinessContext>
    {
        protected override void Seed(BusinessContext context)
        {
            var threads = new List<Threads>
            {
                new Threads{Title = "I need help with programming", CreationDate = DateTime.Now,  }
            };

            threads.ForEach(thread =>
            {
                context.Threads.Add(thread);
            });

            context.SaveChanges();


        }

        
    }
}
