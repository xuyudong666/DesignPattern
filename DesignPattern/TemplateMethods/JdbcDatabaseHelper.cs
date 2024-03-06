using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethods;

public class JdbcDatabaseHelper : DatabaseTemplate
{
    protected override void Connect()
    {
        Console.WriteLine("Jdbc连接数据库");
    }

    protected override void Operation(string sql,DatabaseOperation databaseOperation)
    {
        if(databaseOperation == DatabaseOperation.Query)
        {
            Query(sql);
        }
        else
        {
            Update(sql);
        }
    }
}
