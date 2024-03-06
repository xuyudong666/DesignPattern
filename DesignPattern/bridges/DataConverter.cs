using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.bridges
{
    public abstract class DataConverter
    {
        protected readonly IDataConvert _dataConvert;

        protected DataConverter(IDataConvert dataConvert)
        {
            _dataConvert = dataConvert;
        }

        public abstract void ParseData(string path);
    }
}
