using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKingdom
{
    public class AxeBehavior : WeaponBehavior
    {
        public void useWeapon()
        {
            int inflictedG = damage(3,7);
            Console.WriteLine("удар топором {0} един.урона", inflictedG);
        }
        public int damage(int minG, int maxG) {
            Random r = new Random();
            return r.Next(minG, maxG);
        }
    }
}
