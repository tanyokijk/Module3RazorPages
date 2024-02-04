using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly List<T> items;

    public GenericRepository(List<T> items)
    {
        this.items = items ?? throw new ArgumentNullException(nameof(items));
    }

    public List<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(i => i.GetType().GetProperty("Id")?.GetValue(i, null) as int? == id);
    }

    public void Insert(T entity)
    {
        items.Add(entity);
    }

    public void InsertRange(List<T> entities)
    {
        items.AddRange(entities);
    }

    public void Delete(int id)
    {
        T entity = items.FirstOrDefault(i => i.GetType().GetProperty("Id")?.GetValue(i, null) as int? == id);
        if (entity != null)
            items.Remove(entity);
    }
}