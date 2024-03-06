using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composites
{
    public class TextBox(string name) : Control(name)
    {
        public override void Add(Control control)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Control control)
        {
            throw new NotImplementedException();
        }
    }
}
