using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactorys
{
    public class AndroidControllerFactory : IControllerFactory
    {
        public IInterfaceController CreateController()
        {
            return new AndroidInterfaceController();
        }

        public IOperationController CreateOperationController()
        {
            return new AndroidOperationController();
        }
    }
}
