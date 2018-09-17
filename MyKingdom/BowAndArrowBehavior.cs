using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKingdom
{
    public class BowAndArrowBehavior:WeaponBehavior
    {
        public void useWeapon()
        {
            int inflictedG = damage(1, 5);
            Console.WriteLine("выстрел из лука {0} един.урона", inflictedG);
        }

        public int damage(int minG, int maxG)
        {
            Random r = new Random();
            return r.Next(minG, maxG);
        }
    }
}
