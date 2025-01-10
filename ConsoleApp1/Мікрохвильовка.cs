using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Мікрохвильовка біпає!");
        }
    }
}
