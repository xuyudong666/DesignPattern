namespace DesignPattern.Singletons;

public sealed class DatabasePool
{
    private DatabasePool(int size)
    {
        _databasePools = new List<string>(size);
        for (int i = 0; i < size; i++)
        {
            _databasePools.Add($"连接对象{i}");
        }
    }
    private static object _lock = new object();
    private static DatabasePool Instance;

    private readonly IList<string> _databasePools;

    public static DatabasePool GetInstance(int size)
    {
        if(Instance == null)
        {
            lock(_lock)
            {
                if(Instance == null)
                {
                    return new DatabasePool(size);
                }
            }
        }
        return Instance;
    }

    public string GetConnection()
    {
        return _databasePools[Random.Shared.Next(0,_databasePools.Count)];
    }
}
