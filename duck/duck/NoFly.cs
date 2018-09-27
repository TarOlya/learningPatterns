using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck
{
    class NoFly:IFly
    {
        public void fly() {
            Console.WriteLine("Я не умею летать");
        }
    }
}
