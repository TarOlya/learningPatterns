using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyKingdom
{
    class MyKingdom
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите номер персонажа, которого Вы хотите создать\n(1-король, 2-королева, 3-рыцарь, 4-тролль)");
                int n = int.Parse(Console.ReadLine());
                Character a = createNewCharacter(n);
                Console.WriteLine("Выберите номер оружия выбранного персонажа\n(1-топор, 2-меч, 3-лук и стрелы, 4-нож)");
                int nw = int.Parse(Console.ReadLine());
                a.setWeapon(nw);
                a.display();
                a.fight();
            }
            catch (ArgumentOutOfRangeException) {
                Console.WriteLine("Введен некорректный номер");
            }
        }

        public static Character createNewCharacter(int number) {
            switch (number){
                case 1: return new King() ; 
                case 2: return new Queen(); 
                case 3: return new Knight();
                case 4: return new Troll();
                default: throw new ArgumentOutOfRangeException();
                }
        }
    }
}
