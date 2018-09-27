using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck
{
    class FlyWJetPack:IFly
    {
        public void fly() {
            Console.WriteLine("Я летаю с реактивным ранцем!");
        }
    }
}
