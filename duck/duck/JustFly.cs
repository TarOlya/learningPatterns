using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck
{
    class JustFly:IFly
    {
        public void fly() {
            Console.WriteLine("Я просто летаю");
        }
    }
}
