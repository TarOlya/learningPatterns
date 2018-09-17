using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKingdom
{
    public class KnifeBehavior : WeaponBehavior
    {
        public void useWeapon()
        {
            int inflictedG = damage(3, 6);
            Console.WriteLine("удар ножом {0} един.урона", inflictedG);
        }

        public int damage(int minG, int maxG)
        {
            Random r = new Random();
            return r.Next(minG, maxG);
        }
    }
}
