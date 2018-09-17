using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKingdom
{
    public class SwordBehavior : WeaponBehavior
    {
        public void useWeapon()
        {
            int inflictedG = damage(3, 8);
            Console.WriteLine("удар мечом {0} един.урона", inflictedG);
        }

        public int damage(int minG, int maxG)
        {
            Random r = new Random();
            return r.Next(minG, maxG);
        }
    }
}
