namespace Services;

public class DataService<T> : IDataService<T>
{
    private List<T> items;

    public DataService(List<T> initialItems)
    {
        items = initialItems ?? new List<T>();
    }

    public List<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(i => i.GetType().GetProperty("Id")?.GetValue(i, null) as int? == id);
    }
}