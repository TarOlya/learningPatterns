using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck
{
    class NoQuack:IQuack
    {
        public void quack() {
            Console.WriteLine("Я не умею крякать");
        }
    }
}
