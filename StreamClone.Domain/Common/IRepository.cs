using System.Collections.Generic;

namespace StreamClone.Domain.Common
{
    //TODO: Investigar multiples restricciones en tipos genericos
    public interface IRepository<TEntity, TPrimaryKey> //where TEntity : IAggregateRoot
    {
        IList<TEntity> GetAll();
        TEntity Get(TPrimaryKey key);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TPrimaryKey id);
    }
}