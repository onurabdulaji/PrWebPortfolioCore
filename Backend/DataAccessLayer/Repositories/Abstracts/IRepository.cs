using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Abstracts
{
    public interface IRepository<T> where T : class, IEntity
    {

        // Void Commands
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);


        // List Commands
        List<T> GetList();

        // Find Commands
        T GetById(int id);

        // Expression Commands
        List<T> GetListFilter(Expression<Func<T, bool>> expression);
        T FirstOrDefault(Expression<Func<T, bool>> expression);

        // Queryable Commands
        IQueryable<T> GetListQuery();

        // Async Methods
    }
}
