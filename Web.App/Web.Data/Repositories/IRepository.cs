using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Repositories
{
    public interface IRepository<T>
    {
        void Save(T entity);
        void Save(IList<T> entities);
        T FindById(long id);
        IQueryable<T> Find(Expression<Func<T, bool>> condition);
        void Delete(T entity);
        IEnumerable<T> All();
    }
}
