using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ManagerServices.Absracts
{
    public interface IManager<T> where T : class, IEntity
    {
        // Void Commands
        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);


        // List Commands
        List<T> TGetList();

        // Find Commands
        T TGetById(int id);

        // Expression Commands
        List<T> TGetListFilter(Expression<Func<T, bool>> expression);
        T TFirstOrDefault(Expression<Func<T, bool>> expression);

        // Queryable Commands
        IQueryable<T> TGetListQuery();

        // Async Methods
    }
}
