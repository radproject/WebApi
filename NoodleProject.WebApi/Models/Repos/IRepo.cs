using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NoodleProject.WebApi.Models.Repos
{
    public interface IRepo<T>
    {
        void Create(T model);
        T GetById(int id);
        T[] GetAll();
        void Update(T changedModel);
        void Delete(int id);
    }
}