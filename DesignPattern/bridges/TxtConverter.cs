using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.bridges
{
    public class TxtConverter(IDataConvert dataConvert) : DataConverter(dataConvert)
    {
        public override void ParseData(string path)
        {
            Data data = new();
            _dataConvert.Convert(data);
            Console.WriteLine("格式为:Txt");
        }
    }
}
