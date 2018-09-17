using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKingdom
{
    class Knight:Character
    {

        public override void setWeapon(int nW)
        {
            switch (nW)
            {
                case 1: { AxeBehavior weapon = new AxeBehavior(); this.weapon = weapon; break; }
                case 2: { SwordBehavior weapon = new SwordBehavior(); this.weapon = weapon; break; }
                case 3: { BowAndArrowBehavior weapon = new BowAndArrowBehavior(); this.weapon = weapon; break; }
                case 4: { KnifeBehavior weapon = new KnifeBehavior(); this.weapon = weapon; break; }
                default: throw new ArgumentOutOfRangeException();
            }
        }

        public override void fight()
        {
            weapon.useWeapon();
        }

        public override void display()
        {
            Console.WriteLine("Я рыцарь");
        }
    }
}
