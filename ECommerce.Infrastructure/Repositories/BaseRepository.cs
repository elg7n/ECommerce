using ECommerce.Domain.Interfaces;
using ECommerce.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext DbContext;
        public readonly DbSet<TEntity> Table;
        public BaseRepository()
        {
            DbContext = new AppDbContext();
            Table = DbContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            var addedEntity = Table.Add(entity);

            DbContext.SaveChanges();

            return addedEntity.Entity;
        }

        public void Delete(int id)
        {
            var data = Table.Find(id);  
            
            if (data != null)
            {
                Table.Remove(data);

                DbContext.SaveChanges();
            }
        }

        public virtual List<TEntity> GetAll()
        {
            var data = Table.ToList();  

            return data;
        }

        public virtual TEntity? GetById(int id)
        {
            var data = Table.Find(id);

            return data;
        }

        public virtual void Update(TEntity entity)
        {
            Table.Update(entity);

            DbContext.SaveChanges();
        }
    }
}
