using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NoodleProject.DataLibrary;
using NoodleProject.DataLibrary.Data;

namespace NoodleProject.WebApi.Models.Repos
{
    public class PostsRepository : IRepo<Post>
    {
        BusinessContext context;

        public PostsRepository()
        {
            this.context = new BusinessContext();
        }

        public PostsRepository(BusinessContext context)
        {
            this.context = context;
        }

        public void Create(Post model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Post[] GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Post changedModel, int Id)
        {
            throw new NotImplementedException();
        }
    }
}