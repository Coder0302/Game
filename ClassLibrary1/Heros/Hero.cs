using Heroes.EventArgs;
using Equipment.Interfaces;
using Factories.Factories;
using System;
using Heroes.EventHandlers;

namespace Heroes.Heros
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Hp { get; protected set; }
        public Weapon Weapon { get; protected set; }
        public event AttakedEventHandler Attacked;
        public Armor Armor { get; set; }
        protected AbstractFactories AbstractFactory;
        protected int TakeDamege(int damage)
        {
            int takeDamage;
            if (Armor.Durability < 100)
            {
                takeDamage = damage > Armor.Defence ? damage - Armor.Defence : 0;
                Armor.Using();
            }
            else
                takeDamage = damage;
            Hp -= takeDamage;
            return takeDamage;
        }
        public void Attack(Hero hero)
        {
            if (Weapon.Durability < 100)
            {
                int damage = hero.TakeDamege(Weapon.Damage);
                Weapon.Using();
                Attacked?.Invoke(this, new AttakedEventArgs() { Hero = hero, AttakedHp = damage });
            }
            else
            {
                Console.WriteLine("Оружие сломалось");
            }
        }
        public void Fixed(Equip equip)
        {
            equip.Fix();
        }
        public override string ToString()
        {
            return $"\nИмя: {Name}\nXP: {Hp}\nУрон {Weapon}: {Weapon.Damage}\nЗащита: {Armor}: {Armor.Defence}\nИзнос {Armor} : {Armor.Durability}";
        }
    }
}