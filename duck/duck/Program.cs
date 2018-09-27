using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck
{
    class Program
    {
        static void Main(string[] args)
        {
            MetalDuck a = new MetalDuck();
            a.display();
            a.Fly();
            a.Quack();
            a.Swim();
        }
    }
}
