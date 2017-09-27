using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web.Business.Entities;
using Web.Data.Repositories;

namespace Web.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly WebDbContext webDbContext;
        public Repository(WebDbContext webDbContext)
        {
            this.webDbContext = webDbContext;
        }
        public IEnumerable<T> All()
        {
            return webDbContext.Set<T>().ToList();
        }

        public void Delete(T entity)
        {
            webDbContext.Set<T>().Remove(entity);
            webDbContext.SaveChanges();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> condition)
        {
            return webDbContext.Set<T>().Where(condition);
        }

        public T FindById(long id)
        {
            return webDbContext.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        public void Save(IList<T> entities)
        {
            foreach (var entity in entities)
            {
                webDbContext.Set<T>().Add(entity);
            }
            webDbContext.SaveChanges();
        }

        public void Save(T entity)
        {
            webDbContext.Set<T>().Add(entity);
            webDbContext.SaveChanges();
        }
    }
}
