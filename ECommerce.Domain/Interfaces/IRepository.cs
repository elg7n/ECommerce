using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity? GetById(int id);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
