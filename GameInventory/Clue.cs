          /////////////////////////////////////////////////////////////////////////////////////////////////////////
         //                                                                                                     //
        //                                                                                                     //
       // Project: GameInventory                                                                              //
      // File Name: Rarity                                                                                   //
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
    public class Clue : Item
    {
        protected bool accuracy;
        protected string personIncriminated;

        public Clue() : base()
        {
            personIncriminated = string.Empty;
            accuracy = false;
        }

        /*public Clue(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            personIncriminated = string.Empty;
            accuracy = false;
        }*/

        public Clue(string name, string description, double weight, double value, string incriminates, bool isAccurate) : base(name, description, weight, value)
        {
            accuracy = isAccurate;
            personIncriminated = incriminates;
        }
    }
}
