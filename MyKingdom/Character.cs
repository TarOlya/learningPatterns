using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKingdom
{
    abstract class Character
    {
        public WeaponBehavior weapon;
        public abstract void setWeapon(int nW);
        public abstract void fight();
        public abstract void display();
    }
}
