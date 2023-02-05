          /////////////////////////////////////////////////////////////////////////////////////////////////////////
         //                                                                                                     //
        //                                                                                                     //
       // Project: GameInventory                                                                              //
      // File Name: Weapon                                                                                   //
     // Course: CSCI 2210 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Thursday, January 26, 2023                                                                 //
  // Copyright: Scotty Snyder, 2023                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    //add inheritance from clue class
    public class Weapon : Clue
    {
        protected int Damage;
        protected DamageType DamageType;
        protected RarityType RarityType;

        public Weapon() 
        { 
            Damage = 0;
            DamageType = DamageType.BLUDGEONING;
        }

        public Weapon(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            Damage = 0;
            DamageType = DamageType.BLUDGEONING;
        }

        public Weapon(string name, string description, double weight, double value, int damage, DamageType damageType, RarityType rarityType) :
             base(name, description, weight, value)
        {
            Damage = damage;
            DamageType = damageType;
            RarityType = rarityType;
        }

        public Weapon(string name, string description, double weight, double value, int damage, DamageType damageType, RarityType rarityType, string incriminates, bool isAccurate) :
             base(name, description, weight, value, incriminates, isAccurate)
        {
            Damage = damage;
            DamageType = damageType;
            RarityType = rarityType;

        }

        public override string ToString() 
        {
            string info = "";

            info += $"\nDamage: {Damage}\n";
            info += $"Damage Type: {DamageType}";

            return base.ToString() + info;
        }
    }
}
