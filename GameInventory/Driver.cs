         /////////////////////////////////////////////////////////////////////////////////////////////////////////
        //                                                                                                     //
       // Project: GameInventory                                                                              //
      // File Name: Driver                                                                                   //
     // Course: CSCI 2210 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Thursday, January 26, 2023                                                                 //
  // Copyright: Scotty Snyder, 2023                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace GameInventory
{
    /// <summary>
    /// driver class relates all other classes to the main method
    /// </summary>
    public class Driver
    {
        /// <summary>
        /// main method
        /// </summary>
        static void Main()
        {
            Console.Clear();

            //creates a new backpack, creates new items, weapons, and clues, and puts them in the 
            Backpack playerBackpack = new Backpack();
            playerBackpack.Add(ItemFactory.MakeRandomClue());
            playerBackpack.Add(ItemFactory.MakeRandomClue());
            playerBackpack.Add(ItemFactory.MakeRandomClue(false, "bob"));
            playerBackpack.Add(ItemFactory.MakeRandomClue());
            playerBackpack.Add(ItemFactory.MakeRandomItem());
            playerBackpack.Add(ItemFactory.MakeRandomWeapon(RarityType.RARE));
            playerBackpack.Add(ItemFactory.MakeRandomWeapon(RarityType.UNCOMMON));
            playerBackpack.Add(ItemFactory.MakeRandomWeapon(RarityType.COMMON, true, "Bob"));
            playerBackpack.Add(new Weapon("gun", "it's a gun", 1.5, 765, 60, DamageType.PIERCING, RarityType.RARE));

            //lists all the clues, all the weapons, and finally lists everything
            Console.WriteLine("Backpack Contents:\n\n");
            Console.WriteLine(playerBackpack.ListClues());
            Console.WriteLine(playerBackpack.ListWeapons());
            Console.WriteLine(playerBackpack.ListItems());
        }
    }
}