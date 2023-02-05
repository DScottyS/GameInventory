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
    public class Item
    {
        protected string Description { get; set; }
        protected string Name { get; set; }
        protected RarityType rarity { get; set; }
        protected double Value { get; set; }
        protected double Weight { get; set; }

        public Item() 
        { 
            Name = string.Empty;
            Description = string.Empty;
            Value = 0;
            Weight = 0;
        }

        public Item(string name, string description, double weight, double value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }

        public override string ToString()
        {
            string info = string.Empty;

            info += $"{Name}\n";
            info += $"{Description}\n";
            info += $"{Weight} \n";
            info += $"{Value}";

            return info;
        }

    }
}
