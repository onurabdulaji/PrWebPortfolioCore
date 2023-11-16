﻿using DataAccessLayer.Context;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concretes
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        MyContext _db;

        public BaseRepository(MyContext db)
        {
            _db = db;
        }

        public void Add(T entity)
        {
            entity.InsertedDate = DateTime.Now;
            _db.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().FirstOrDefault(expression);
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetListFilter(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().Where(expression).ToList();
        }

        public IQueryable<T> GetListQuery()
        {
            return _db.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}
