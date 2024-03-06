using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.bridges
{
    public class MySqlConverter : IDataConvert
    {
        public void Convert(Data data)
        {
            Console.WriteLine("查询MySql转换数据");
        }
    }
}
