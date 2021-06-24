using ejemplo.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ejemplo.DataAccess
{
    public class DbContext<T> : IDbContext<T> where T : class ,IEntity
    {
        //IList<T> _data;
        DbSet<T> _item;
        ApiDbContext _ctx;
        public DbContext(ApiDbContext ctx)
        {
            _ctx = ctx;
            _item = ctx.Set<T>();
            //_data = new List<T>();
        }

        public void Delete(int id)
        {
            //var e = _data.Where(u => u.Id.Equals(id)).FirstOrDefault();
            //if(e!=null)
            //{
            //    _data.Remove(e);
            //}
        }

        public IList<T> GetAll()
        {
            //return _data;
            return _item.ToList();
        }

        public T GetById(int id)
        {
            //return _data.Where(u => u.Id.Equals(id)).FirstOrDefault();
            return _item.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public T Save(T entity)
        {
            //if (entity.Id.Equals(0))
            //{
            //    _data.Add(entity);
            //}
            //else
            //{

            //}

            //return entity;

            _item.Add(entity);
            _ctx.SaveChanges();
            return entity;
        }
    }
}
