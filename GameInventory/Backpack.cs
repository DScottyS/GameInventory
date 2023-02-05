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
    public class Backpack
    {
        public static List<Item> Contents;

        public Backpack()
        {
            Contents = new List<Item>();
        }

        public void Add(Item item)
        {
            Contents.Add(item);
        }

        public string ListClues()
        {
            string clue = string.Empty;

            clue += "Clues: ---------------------------\n";
            foreach (Item c in Contents)
            {
                if (c is Clue)
                {
                    clue += $"{c}\n";
                    clue += "----------------------------------\n";
                }
            }

            return clue;
        }

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
