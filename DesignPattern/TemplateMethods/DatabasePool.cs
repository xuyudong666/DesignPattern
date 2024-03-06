using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethods;

public class DatabasePool : DatabaseTemplate
{
    protected override void Connect()
    {
        Console.WriteLine("数据库连接池连接数据库");
    }

    protected override void Operation(string sql, DatabaseOperation databaseOperation)
    {
        if (databaseOperation == DatabaseOperation.Query)
        {
            Query(sql);
        }
        else
        {
            Update(sql);
        }
    }
}
