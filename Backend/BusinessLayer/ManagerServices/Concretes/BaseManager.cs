using BusinessLayer.ManagerServices.Absracts;
using DataAccessLayer.Repositories.Abstracts;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ManagerServices.Concretes
{
    public class BaseManager<T> : IManager<T> where T : class, IEntity
    {
        protected IRepository<T> _Irepository;

        public BaseManager(IRepository<T> irepository)
        {
            _Irepository = irepository;
        }

        public void TAdd(T entity)
        {
            entity.InsertedDate = DateTime.Now;
            _Irepository.Add(entity);
        }

        public void TDelete(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            _Irepository.Delete(entity);
        }

        public T TFirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return _Irepository.FirstOrDefault(expression);
        }

        public T TGetById(int id)
        {
            return _Irepository.GetById(id);
        }

        public List<T> TGetList()
        {
            return _Irepository.GetList();
        }

        public List<T> TGetListFilter(Expression<Func<T, bool>> expression)
        {
            return _Irepository.GetListFilter(expression);
        }

        public IQueryable<T> TGetListQuery()
        {
            return _Irepository.GetListQuery();
        }

        public void TUpdate(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _Irepository.Update(entity);
        }
    }
}
