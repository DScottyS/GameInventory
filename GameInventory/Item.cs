          /////////////////////////////////////////////////////////////////////////////////////////////////////////
         //                                                                                                     //
        //                                                                                                     //
       // Project: GameInventory                                                                              //
      // File Name: Item                                                                                     //
     // Course: CSCI 2210 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Sunday, January 26, 2023                                                                   //
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
    public class Item
    {
        protected string Description;
        protected string Name;
        protected Rarity rarity;
        protected double Value;
        protected double Weight;

        public Item(string name, string description, double weight, double value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }

        public override string ToString()
        {
            string info = "";

            info += "------------------------------------------";
            info += $"{Name}";
            info += $"{Description}";
            info += $"{Weight}";
            info += $"{Value}";
            info += "------------------------------------------";

            return info;
        }

    }
}
