using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategys
{
    public class Aircraft
    {
        public Aircraft(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
        }

        public string Model { get; set; }
        public int Capacity { get; set; }

        public ISonicFly SonicFly { get; set; }
        public ITakeOffable TakeOffable { get; set; }

        public void TakeOff()
        {
            Console.WriteLine($"{Model}起飞特征");
            TakeOffable.TakeOff();
        }

        public void Fly()
        {
            Console.WriteLine($"{Model}飞行特征");
            SonicFly.SonicFly();
        }
    }
}
