using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Steamboat : Device
    {

        public Steamboat(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Пароплав свистить і парить!");
        }
    }
}
