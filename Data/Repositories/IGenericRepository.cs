using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;

public interface IGenericRepository<TEntity>
    where TEntity : class
{
    List<TEntity> GetAll();

    TEntity GetById(int id);

    void Insert(TEntity entity);

    void InsertRange(List<TEntity> entity);

    void Delete(int id);

}