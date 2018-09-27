using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duck
{
    class MetalDuck:Duck
    {
        IFly f = new NoFly();
        ISwim s = new NoSwim();
        IQuack q = new NoQuack();
        public override void Fly()
        {
            f.fly();
        }
        public override void Quack()
        {
            q.quack();
        }
        public override void Swim()
        {
            s.swim();
        }
        public override void display()
        {
            Console.WriteLine("Я металлическая уточка"); ;
        }
    }
}
