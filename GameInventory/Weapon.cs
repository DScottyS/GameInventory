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

        /*public Weapon(string name, string description, double weight, double value, int damage, DamageType damageType) :
            base(name, description, weight, value)
        {
            Damage = damage;
            DamageType = damageType;
        }*/

        public override string ToString() 
        {
            string info = string.Empty;

            info += $"Damage: {Damage}";
            info += $"Damage Type: {DamageType}";

            return info;
        }
    }
}
