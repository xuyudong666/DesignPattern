using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composites
{
    public class Panel(string name) : Control(name)
    {
        private readonly IList<Control> _controls = [];

        public override void Add(Control control)
        {
            _controls.Add(control);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);

            foreach (var contorl in _controls)
            {
                contorl.Display(depth + 2);
            }
        }

        public override void Remove(Control control)
        {
            _controls.Remove(control);
        }
    }
}
