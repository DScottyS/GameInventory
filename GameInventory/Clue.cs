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
    /// <summary>
    /// clue class derives from the item class to create clue objects
    /// </summary>
    public class Clue : Item
    {
        //determines whether or not the clue is accurate
        protected bool accuracy;
        //string that determines the person incriminated
        protected string personIncriminated;

        /// <summary>
        /// default constructor
        /// </summary>
        public Clue() : base()
        {
            personIncriminated = string.Empty;
            accuracy = false;
        }

        /// <summary>
        /// parameterized constructor that takes name, description, weight, and value
        /// </summary>
        /// <param name="name">the name of the clue</param>
        /// <param name="description">the description of the clue</param>
        /// <param name="weight">the weight of the clue</param>
        /// <param name="value">the value of the clue</param>
        public Clue(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            personIncriminated = string.Empty;
            accuracy = false;
        }

        /// <summary>
        /// parameterized constructor that takes name, description, weight, and value
        /// </summary>
        /// <param name="name">the name of the clue</param>
        /// <param name="description">the description of the clue</param>
        /// <param name="weight">the weight of the clue</param>
        /// <param name="value">the value of the clue</param>
        /// <param name="incriminates">the name of who the clue incriminates</param>
        /// <param name="isAccurate">bool that determines whether or not the clue is accurate</param>
        public Clue(string name, string description, double weight, double value, string incriminates, bool isAccurate) : base(name, description, weight, value)
        {
            accuracy = isAccurate;
            personIncriminated = incriminates;
        }
    }
}
