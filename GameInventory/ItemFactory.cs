          /////////////////////////////////////////////////////////////////////////////////////////////////////////
         //                                                                                                     //
        //                                                                                                     //
       // Project: GameInventory                                                                              //
      // File Name: Item Factory                                                                             //
     // Course: CSCI 2210 – Introduction to Computer Science II                                             //
    // Author: Scotty Snyder, snyderds@etsu.edu, Department of Computing, East Tennessee State University  //
   // Created: Sunday, January 26, 2023                                                                   //
  // Copyright: Scotty Snyder, 2023                                                                      //
 //                                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace GameInventory
{
    /// <summary>
    /// ItemFactory class communicates with the Item, Weapon, and Clue classes to create new objects of their respective types
    /// </summary>
    public class ItemFactory
    {
        //creates a new random that will be used to determine various attributes
        public static Random rand = new Random();
        //creates a StreamReader so the program can read from the associated text file
        public static StreamReader ItemReader;

        /// <summary>
        /// method creates a randomized clue using the data given to it in the respective text file
        /// </summary>
        /// <returns>A randomized Clue object based of the provided text file in the method</returns>
        public static Clue MakeRandomClue()
        {
            Clue randomClue;
            //uses the text file provded in the project's bin\Debug\net6.0\Item Files
            ItemReader = new StreamReader("Item Files\\Clues.txt");

            //reads the first four lines of the provided file and uses the respective delimiters to parse the data
            string lineOne = ItemReader.ReadLine();
            string[] clueName = lineOne.Split("-");
            string lineTwo = ItemReader.ReadLine();
            string[] clueDesc = lineTwo.Split("|");
            string lineThree = ItemReader.ReadLine();
            string[] clueWeight = lineThree.Split("/");
            string lineFour = ItemReader.ReadLine();
            string[] clueValue = lineFour.Split(",");

            //creates a new randomized clue by taking the arrays created above and getting a random number within the array's index
            randomClue = new Clue(clueName[rand.Next(0, clueName.Length)], clueDesc[rand.Next(0, clueDesc.Length)],
                 double.Parse(clueWeight[rand.Next(0, clueWeight.Length)]), double.Parse(clueValue[rand.Next(0, clueValue.Length)]));

            //closes the item StreamReader so conflictions do not occur and returns the object to the driver
            ItemReader.Close();
            return randomClue;
        }

        /// <summary>
        /// method creates a randomized clue using the data given to it in the respective text file and user information
        /// </summary>
        /// <param name="isAccurate">Boolean that determines if the Clue is accurate</param>
        /// <param name="incriminates">String that determines an incrminated party</param>
        /// <returns>A randomized Clue object based of the provided text file in the method and the input </returns>
        public static Clue MakeRandomClue(bool isAccurate, string incriminates)
        {
            Clue randomClue;
            //uses the text file provded in the project's bin\Debug\net6.0\Item Files
            ItemReader = new StreamReader("Item Files\\Clues.txt");

            //reads the first four lines of the provided file and uses the respective delimiters to parse the data
            string lineOne = ItemReader.ReadLine();
            string[] clueName = lineOne.Split("-");
            string lineTwo = ItemReader.ReadLine();
            string[] clueDesc = lineTwo.Split("|");
            string lineThree = ItemReader.ReadLine();
            string[] clueWeight = lineThree.Split("/");
            string lineFour = ItemReader.ReadLine();
            string[] clueValue = lineFour.Split(",");

            //creates a new randomized clue by taking the arrays created above and getting a random number within the array's index
            randomClue = new Clue(clueName[rand.Next(0, clueName.Length)], clueDesc[rand.Next(0, clueDesc.Length)],
                 double.Parse(clueWeight[rand.Next(0, clueWeight.Length)]), double.Parse(clueValue[rand.Next(0, clueValue.Length)]), incriminates, isAccurate);

            //closes the item StreamReader so conflictions do not occur and returns the object to the driver
            ItemReader.Close();
            return randomClue;
        }

        /// <summary>
        /// uses a random number to chose whether it should create a weapon or a clue
        /// </summary>
        /// <returns></returns>
        public static Item MakeRandomItem()
        {
            if (rand.Next(1, 3) == 1)
            {
                return MakeRandomClue();
            }
            else
            {
                //generates a random rarity and uses it to create a random weapon
                //ln 63-64 are heavily referenced from https://stackoverflow.com/questions/3132126/how-do-i-select-a-random-value-from-an-enumeration
                Array rarities = Enum.GetValues(typeof(RarityType));
                RarityType randomRarity = (RarityType)rarities.GetValue(rand.Next(rarities.Length));

                return MakeRandomWeapon(randomRarity);
            }
        }

        /// <summary>
        /// creates a randomized weapon using using the data given to it in the respective text file and user information
        /// </summary>
        /// <param name="rarity"></param>
        /// <returns></returns>
        public static Weapon MakeRandomWeapon(RarityType rarity)
        {
            Weapon randomWeapon;
            //uses the text file provded in the project's bin\Debug\net6.0\Item Files
            StreamReader WeaponReader = new StreamReader("Item Files\\Weapons.txt");

            //reads the first five lines of the provided file and uses the respective delimiters to parse the data
            string lineOne = WeaponReader.ReadLine();
            string[] weaponName = lineOne.Split("-");
            string lineTwo = WeaponReader.ReadLine();
            string[] weaponDesc = lineTwo.Split("|");
            string lineThree = WeaponReader.ReadLine();
            string[] weaponWeight = lineThree.Split("/");
            string lineFour = WeaponReader.ReadLine();
            string[] weaponValue = lineFour.Split(",");
            string lineFive = WeaponReader.ReadLine();
            string[] weaponDmg = lineFive.Split(">");

            //generates a random damage type for the weapon to deal
            //ln 63-64 are heavily referenced from https://stackoverflow.com/questions/3132126/how-do-i-select-a-random-value-from-an-enumeration
            Array dmgTypes = Enum.GetValues(typeof(DamageType));
            DamageType randomDmgType = (DamageType)dmgTypes.GetValue(rand.Next(dmgTypes.Length));

            //creates a new randomized weapon by taking the arrays created above and getting a random number within the array's index, radomized damage type from lns 139-140,
            //and the rarity input into the method
            randomWeapon = new Weapon(weaponName[rand.Next(0, weaponName.Length)], weaponDesc[rand.Next(0, weaponDesc.Length)],
                 double.Parse(weaponWeight[rand.Next(0, weaponWeight.Length)]), double.Parse(weaponValue[rand.Next(0, weaponValue.Length)]), 
                 int.Parse(weaponDmg[rand.Next(0, weaponDmg.Length)]), randomDmgType, rarity);

            //closes the item StreamReader so conflictions do not occur and returns the object to the driver
            WeaponReader.Close();
            return randomWeapon;
        }

        /// <summary>
        /// creates a randomized weapon using using the data given to it in the respective text file and user information
        /// </summary>
        /// <param name="rarity">determines the rarity of the weapon</param>
        /// <param name="isAccurate">Boolean that determines if the Clue is accurate</param>
        /// <param name="incriminates">String that determines an incrminated party</param>
        /// <returns>A randomized Clue object based of the provided text file in the method and the input </returns>
        public static Weapon MakeRandomWeapon(RarityType rarity, bool isAccurate, string incriminates)
        {
            Weapon randomWeapon;
            //uses the text file provded in the project's bin\Debug\net6.0\Item Files
            StreamReader WeaponReader = new StreamReader("Item Files\\Weapons.txt");

            //reads the first five lines of the provided file and uses the respective delimiters to parse the data
            string lineOne = WeaponReader.ReadLine();
            string[] weaponName = lineOne.Split("-");
            string lineTwo = WeaponReader.ReadLine();
            string[] weaponDesc = lineTwo.Split("|");
            string lineThree = WeaponReader.ReadLine();
            string[] weaponWeight = lineThree.Split("/");
            string lineFour = WeaponReader.ReadLine();
            string[] weaponValue = lineFour.Split(",");
            string lineFive = WeaponReader.ReadLine();
            string[] weaponDmg = lineFive.Split(">");

            Array dmgTypes = Enum.GetValues(typeof(DamageType));
            DamageType randomDmgType = (DamageType)dmgTypes.GetValue(rand.Next(dmgTypes.Length));

            //creates a new randomized weapon by taking the arrays created above and getting a random number within the array's index, radomized damage type from lns 139-140,
            //and information the user input into the method
            randomWeapon = new Weapon(weaponName[rand.Next(0, weaponName.Length)], weaponDesc[rand.Next(0, weaponDesc.Length)],
                 double.Parse(weaponWeight[rand.Next(0, weaponWeight.Length)]), double.Parse(weaponValue[rand.Next(0, weaponValue.Length)]),
                 int.Parse(weaponDmg[rand.Next(0, weaponDmg.Length)]), randomDmgType, rarity, incriminates, isAccurate);

            //closes the item StreamReader so conflictions do not occur and returns the object to the driver
            WeaponReader.Close();
            return randomWeapon;
        }

/*        public Clue ClueData()
        {
            string lineOne = ItemReader.ReadLine();
            string[] weaponName = lineOne.Split("-");
            string lineTwo = ItemReader.ReadLine();
            string[] weaponDesc = lineTwo.Split("|");
            string lineThree = ItemReader.ReadLine();
            string[] weaponWeight = lineThree.Split(".");
            string lineFour = ItemReader.ReadLine();
            string[] weaponValue = lineFour.Split(",");

            return new Clue(weaponName[rand.Next(0, weaponName.Length - 1)], weaponDesc[rand.Next(0, weaponDesc.Length - 1)],
                 double.Parse(weaponWeight[rand.Next(0, weaponWeight.Length - 1)]), double.Parse(weaponValue[rand.Next(0, weaponValue.Length - 1)]));
        }
*/
    }
}
