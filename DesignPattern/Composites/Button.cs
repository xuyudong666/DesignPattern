using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composites
{
    public class Button(string name) : Control(name)
    {
        public override void Add(Control control)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
        }

        public override void Remove(Control control)
        {
            throw new NotImplementedException();
        }
    }
}
