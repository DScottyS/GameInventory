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
    /// <summary>
    /// Weapon class inherits from the clue class to create weapon items
    /// </summary>
    public class Weapon : Clue
    {
        //amount of damage the weapon will deal
        protected int Damage;
        //the type of damage the weapon will deal
        protected DamageType DamageType;
        //the rarity of the weapon
        protected RarityType RarityType;

        /// <summary>
        /// deafult constructor
        /// </summary>
        public Weapon() 
        { 
            Damage = 0;
            DamageType = DamageType.BLUDGEONING;
        }

        /// <summary>
        /// parameterized constructor that takes name, description weight, and value
        /// </summary>
        /// <param name="name">name ofthe weapon</param>
        /// <param name="description">description of the weapon</param>
        /// <param name="weight">weight of the weapon</param>
        /// <param name="value">value of the weapon</param>
        public Weapon(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            Damage = 0;
            DamageType = DamageType.BLUDGEONING;
        }

        /// <summary>
        /// parameterized constructor that takes name, description weight, and value
        /// </summary>
        /// <param name="name">name ofthe weapon</param>
        /// <param name="description">description of the weapon</param>
        /// <param name="weight">weight of the weapon</param>
        /// <param name="value">value of the weapon</param>
        /// <param name="damage">how much damage the weapon will deal</param>
        /// <param name="damageType">what type of damage the weapon deals</param>
        /// <param name="rarityType">the rearity of the weapon</param>
        public Weapon(string name, string description, double weight, double value, int damage, DamageType damageType, RarityType rarityType) :
             base(name, description, weight, value)
        {
            Damage = damage;
            DamageType = damageType;
            RarityType = rarityType;
        }

        /// <summary>
        /// parameterized constructor that takes name, description weight, and value
        /// </summary>
        /// <param name="name">name ofthe weapon</param>
        /// <param name="description">description of the weapon</param>
        /// <param name="weight">weight of the weapon</param>
        /// <param name="value">value of the weapon</param>
        /// <param name="damage">how much damage the weapon will deal</param>
        /// <param name="damageType">what type of damage the weapon deals</param>
        /// <param name="rarityType">the rearity of the weapon</param>
        /// <param name="incriminates">who the weapon incriminates </param>
        /// <param name="isAccurate">boolean determining whether or not the weapon is accurate</param>
        public Weapon(string name, string description, double weight, double value, int damage, DamageType damageType, RarityType rarityType, string incriminates, bool isAccurate) :
             base(name, description, weight, value, incriminates, isAccurate)
        {
            Damage = damage;
            DamageType = damageType;
            RarityType = rarityType;

        }

        /// <summary>
        /// ToString adds string information pertinent to the weapons to the item class's ToString
        /// </summary>
        /// <returns>the information required to display a weapon</returns>
        public override string ToString() 
        {
            string info = "";

            info += $"\nDamage: {Damage}\n";
            info += $"Damage Type: {DamageType}";

            return base.ToString() + info;
        }
    }
}
