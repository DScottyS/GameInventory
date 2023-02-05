          /////////////////////////////////////////////////////////////////////////////////////////////////////////
         //                                                                                                     //
        //                                                                                                     //
       // Project: GameInventory                                                                              //
      // File Name: Backpack                                                                                 //
     // Course: CSCI 2210 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Thursday, January 26, 2023                                                                 //
  // Copyright: Scotty Snyder, 2023                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    /// <summary>
    /// backpack class contains all the items, weapons, and clues
    /// </summary>
    public class Backpack
    {
        //creates a new list for all of the items of the backpack to be stored in
        public static List<Item> Contents;

        /// <summary>
        /// default constructor
        /// </summary>
        public Backpack()
        {
            Contents = new List<Item>();
        }

        /// <summary>
        /// adds an item to the backpack
        /// </summary>
        /// <param name="item">item to de added to the backpack</param>
        public void Add(Item item)
        {
            Contents.Add(item);
        }

        /// <summary>
        /// lists all clues in the backpack
        /// </summary>
        /// <returns>a string containing all clues in the backpack</returns>
        public string ListClues()
        {
            string clue = string.Empty;

            clue += "Clues: ---------------------------\n";
            foreach (Item c in Contents)
            {
                if (c is Clue && c is not Weapon)
                {
                    clue += $"{c}\n";
                    clue += "----------------------------------\n";
                }
            }

            return clue;
        }

        /// <summary>
        /// lists all items in the backpack
        /// </summary>
        /// <returns>a string containing all items in the backpack</returns>
        public string ListItems()
        {
            string contents = string.Empty;

            contents += "Items: ---------------------------\n";

            foreach (Item i in Contents)
            {
                if (i is Item)
                {
                    contents += $"{i}\n";
                    contents += "----------------------------------\n";
                }
            }

            return contents;
        }

        /// <summary>
        /// lists all weapons in the backpack
        /// </summary>
        /// <returns>a string containing all weapons in the backpack</returns>
        public string ListWeapons()
        {
            string weapon = string.Empty;

            weapon += "Weapons: -------------------------\n";
            foreach (Item w in Contents) 
            { 
                if (w is Weapon)
                {
                    weapon += $"{w}\n";
                    weapon += "----------------------------------\n";
                }
            }

            return weapon;
        }
    }
}
