using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kettle : Device
    {

        public Kettle(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Чайник свистить!");
        }
    }
}
