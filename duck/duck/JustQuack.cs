using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck
{
    class JustQuack:IQuack
    {
        public void quack()
        {
            Console.WriteLine("Я просто крякаю");
        }
    }
}
