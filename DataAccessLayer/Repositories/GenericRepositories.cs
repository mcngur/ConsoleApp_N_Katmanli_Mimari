﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepositories<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Delete(T t)
        {
            c.Set<T>().Remove(t);
            c.SaveChanges();
            
        }

        public T GetByID(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            c.Set<T>().Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            c.SaveChanges();
        }
    }
}
