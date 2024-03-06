using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactorys
{
    public class IosControllerFactory : IControllerFactory
    {
        public IInterfaceController CreateController()
        {
            return new IosInterfaceController();
        }

        public IOperationController CreateOperationController()
        {
            return new IosOperationController();
        }
    }
}
