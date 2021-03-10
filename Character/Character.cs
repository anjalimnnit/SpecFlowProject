using System;
using System.Collections.Generic;

namespace GameCharacter
{
    public class Character
    {
        public string _name;
        public Type Type { get; }
        public Character(Type type)
        {
            Type = type;
        }
        public int Armor
        {
            get
            {
                switch (Type)
                {
                    case Type.Elf:
                        return (int)Math.Pow(5, 2);
                    case Type.Ork:
                        return (int)Math.Pow(6, 2);
                    default:
                        break;
                }
                throw new ArgumentOutOfRangeException();
            }
        }
        public List<Weapon> Weapons { get; set; } = new List<Weapon>();
        public int Wear { get; set; } = 15;
        public int Health { get; private set; } = 100;
       public void Steal(string name)
        {
            Weapons.RemoveAll(weapon => weapon.Name == name);   
        }

        public Spell Spell { get; set; }
        public int Defence
        {
            get
            {
                int result = Wear >= Armor ? 0 : Armor - Wear;
                if(Spell==Spell.GreenBlock)
                {
                    result += 25;
                }
                if(Spell==Spell.DarkSpoil)
                {
                    result -= 10;
                }
                return result <= 0 ? 0 : result;
            }
        }
        public bool IsDead()
        {
            return Health <= 0;
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                //    OnPropertyChanged("Name");
            }
        }
        public void Hit(int hit)
        {
            int damage = hit - Defence;
            Health -= damage < 0 ? 0 : damage;
        }
        //  public event PropertyChangedEventHandler PropertyChanged;
    }
}

