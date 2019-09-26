using Equipment.EventArgs;
using Equipment.Interfaces;
using Heroes.Heros;
using System;
namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            Archer archer = new Archer();
            Warrior warrior = new Warrior();

            archer.Attacked += (sender, arg) => { Console.WriteLine($"{(sender as Hero)?.Name} атаковал {arg.Hero.Name} с уроном {arg.AttakedHp}"); };
            warrior.Attacked += (sender, arg) => { Console.WriteLine($"{(sender as Hero)?.Name} атаковал {arg.Hero.Name} с уроном {arg.AttakedHp}"); };
            archer.Weapon.Used += Message;
            archer.Armor.Used += Message;
            warrior.Weapon.Used += Message;
            warrior.Armor.Used += Message;
            while (archer.Hp > 0 && warrior.Hp > 0)
            {
                Console.WriteLine(archer);
                archer.Attack(warrior);
                Console.WriteLine(warrior);
                warrior.Attack(archer);
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine(archer.Hp <= 0 ? "Лучник помер" : "Воин пал смертью храбрых");
            Console.ReadKey();
        }
        static void Message(object sender, UsedEventArgs e)
        {
            Equip equip = (Equip)sender;
            Console.WriteLine($"Износ {equip}: {equip.Durability}");
        }
    }
}