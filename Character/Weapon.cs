using System;
using System.Collections.Generic;
using System.Text;

namespace GameCharacter
{
   public class Weapon
    {
     public  string Name { get; }
      public int Price { get; }
     
      public  int Power { get; set; }
       public Weapon(string name,int price,int power)
        { 
            Name= name ??throw new ArgumentNullException(nameof(name));
            Price = price;
            Power = power;

           }
    }
}
