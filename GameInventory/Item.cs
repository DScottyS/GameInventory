          /////////////////////////////////////////////////////////////////////////////////////////////////////////
         //                                                                                                     //
        //                                                                                                     //
       // Project: GameInventory                                                                              //
      // File Name: Item                                                                                     //
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
    /// Item class creates the backbone for Clue and Weapon classes to be based off of 
    /// </summary>
    public class Item
    {
        //description of the item
        protected string Description { get; set; }
        //name of the item
        protected string Name { get; set; }
        //rarity of the item
        protected RarityType rarity { get; set; }
        //value of the item
        protected double Value { get; set; }
        //weight of the item
        protected double Weight { get; set; }

        /// <summary>
        /// default constructor for the item class
        /// </summary>
        public Item() 
        { 
            Name = string.Empty;
            Description = string.Empty;
            Value = 0;
            Weight = 0;
        }

        /// <summary>
        /// itemized constructor
        /// </summary>
        /// <param name="name">the name of item</param>
        /// <param name="description">the description of the item</param>
        /// <param name="weight">the weight of the item</param>
        /// <param name="value">the value of the item</param>
        public Item(string name, string description, double weight, double value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }

        /// <summary>
        /// String representation of the variables above
        /// </summary>
        /// <returns>a string representation of the variables required to make an item</returns>
        public override string ToString()
        {
            string info = string.Empty;

            info += $"Name: {Name}\n";
            info += $"Description: {Description}\n";
            info += $"Weight: {Weight} lbs\n";
            info += $"Value: {Value}";

            return info;
        }
    }
}
