          /////////////////////////////////////////////////////////////////////////////////////////////////////////
         //                                                                                                     //
        //                                                                                                     //
       // Project: GameInventory                                                                              //
      // File Name: Driver                                                                                   //
     // Course: CSCI 2210 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Thursday, January 26, 2023                                                                 //
  // Copyright: Scotty Snyder, 2023                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Security.Cryptography.X509Certificates;

namespace GameInventory
{
    public class Driver
    {
        static void Main(string[] args)
        {
            Backpack playerBackpack = new Backpack();
            playerBackpack.Add(ItemFactory.MakeRandomClue());
            playerBackpack.Add(ItemFactory.MakeRandomClue());
            playerBackpack.Add(ItemFactory.MakeRandomClue());
            playerBackpack.Add(ItemFactory.MakeRandomItem());
            playerBackpack.Add(ItemFactory.MakeRandomWeapon(RarityType.RARE));
            playerBackpack.Add(ItemFactory.MakeRandomWeapon(RarityType.UNCOMMON));

            Console.WriteLine(playerBackpack.ListClues());
            //Console.WriteLine(playerBackpack.ListItems());
            Console.WriteLine(playerBackpack.ListWeapons());
        }
    }
}