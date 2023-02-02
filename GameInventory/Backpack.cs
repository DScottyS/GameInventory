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
            string info = string.Empty;

            foreach (Item C in Contents)
            {
                if (C is Clue)
                {
                    info += "--------------------------------";
                    info += $"{C}";
                    info += "--------------------------------";
                }
            }

            return info;
        }

        public static string ListItems()
        {
            string info = string.Empty;

            foreach (Item I in Contents)
            {
                if (I is Item)
                {
                    info += "--------------------------------";
                    info += $"{I}";
                    info += "--------------------------------";
                }
            }

            return info;
        }

        public static string ListWeapons()
        {
            string info = string.Empty;

            foreach (Item W in Contents) 
            { 
                if (W is Weapon)
                {
                    info += "--------------------------------";
                    info += $"{W}";
                    info += "--------------------------------";
                }
            }

            return info;
        }
    }
}
