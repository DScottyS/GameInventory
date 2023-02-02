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

        public static void Add(Item item)
        {
            Contents.Add(item);
        }

        Backpack()
        {
            Contents = new List<Item>();
        }

        public static string ListClues()
        {
            string clue = string.Empty;

            foreach (Item c in Contents)
            {
                if (c is Clue)
                {
                    clue += "--------------------------------";
                    clue += $"{c}";
                    clue += "--------------------------------";
                }
            }

            return clue;
        }

        public static string ListItems()
        {
            string contents = string.Empty;

            foreach (Item i in Contents)
            {
                if (i is Item)
                {
                    contents += "--------------------------------";
                    contents += $"{i}";
                    contents += "--------------------------------";
                }
            }

            return contents;
        }

        public static string ListWeapons()
        {
            string weapon = string.Empty;

            foreach (Item w in Contents) 
            { 
                if (w is Weapon)
                {
                    weapon += "--------------------------------";
                    weapon += $"{w}";
                    weapon += "--------------------------------";
                }
            }

            return weapon;
        }
    }
}
