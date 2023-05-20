using System.

namespace MySocialNetwork.Models.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}