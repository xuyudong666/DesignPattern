namespace DesignPattern.TemplateMethods;

public abstract class DatabaseTemplate
{
    protected abstract void Connect();
    private void Open()
    {
        Console.WriteLine("打开数据库");
    }
    protected abstract void Operation(string sql, DatabaseOperation databaseOperation);
    private void Close()
    {
        Console.WriteLine("关闭数据库");
    }
    protected void Query(string sql)
    {
        Console.WriteLine($"查询数据库:{sql}");
    }
    protected void Update(string sql)
    {
        Console.WriteLine($"更新数据库:{sql}");
    }

    public void Handle(string sql, DatabaseOperation databaseOperation)
    {
        Connect();
        Open();
        Operation(sql, databaseOperation);
        Close();
    }
}
