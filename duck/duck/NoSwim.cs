using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck
{
    class NoSwim:ISwim
    {
        public void swim() {
            Console.WriteLine("Я плыву. На дно");
        }
    }
}
