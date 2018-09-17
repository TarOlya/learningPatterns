using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKingdom
{
    public interface WeaponBehavior
    {
        void useWeapon();
        int damage(int minG, int maxG);
    }
}
