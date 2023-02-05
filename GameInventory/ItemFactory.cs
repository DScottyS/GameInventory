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
        public static StreamReader ItemReader;

        public static Clue MakeRandomClue()
        {
            Clue randomClue;
            ItemReader = new StreamReader("Item Files\\Clues.txt");

            string lineOne = ItemReader.ReadLine();
            string[] clueName = lineOne.Split("-");
            string lineTwo = ItemReader.ReadLine();
            string[] clueDesc = lineTwo.Split("|");
            string lineThree = ItemReader.ReadLine();
            string[] clueWeight = lineThree.Split(".");
            string lineFour = ItemReader.ReadLine();
            string[] clueValue = lineFour.Split(",");

            randomClue = new Clue(clueName[rand.Next(0, clueName.Length)], clueDesc[rand.Next(0, clueDesc.Length)],
                 double.Parse(clueWeight[rand.Next(0, clueWeight.Length)]), double.Parse(clueValue[rand.Next(0, clueValue.Length)]));

            ItemReader.Close();
            return randomClue;
        }

        public static Clue MakeRandomClue(bool isAccurate, string incriminates)
        {
            Clue randomClue;
            ItemReader = new StreamReader("Item Files\\Clues.txt");

            string lineOne = ItemReader.ReadLine();
            string[] clueName = lineOne.Split("-");
            string lineTwo = ItemReader.ReadLine();
            string[] clueDesc = lineTwo.Split("|");
            string lineThree = ItemReader.ReadLine();
            string[] clueWeight = lineThree.Split(".");
            string lineFour = ItemReader.ReadLine();
            string[] clueValue = lineFour.Split(",");

            randomClue = new Clue(clueName[rand.Next(0, clueName.Length)], clueDesc[rand.Next(0, clueDesc.Length)],
                 double.Parse(clueWeight[rand.Next(0, clueWeight.Length)]), double.Parse(clueValue[rand.Next(0, clueValue.Length)]), incriminates, isAccurate);

            ItemReader.Close();
            return randomClue;
        }

        public static Item MakeRandomItem()
        {
            if (rand.Next(1, 3) == 1)
            {
                return MakeRandomClue();
            }
            else
            {
                //ln 63-64 are heavily referenced from https://stackoverflow.com/questions/3132126/how-do-i-select-a-random-value-from-an-enumeration
                Array rarities = Enum.GetValues(typeof(RarityType));
                RarityType randomRarity = (RarityType)rarities.GetValue(rand.Next(rarities.Length));

                return MakeRandomWeapon(randomRarity);
            }
        }

        public static Weapon MakeRandomWeapon(RarityType rarity)
        {
            Weapon randomWeapon;
            StreamReader WeaponReader = new StreamReader("Item Files\\Weapons.txt");

            string lineOne = WeaponReader.ReadLine();
            string[] weaponName = lineOne.Split("-");
            string lineTwo = WeaponReader.ReadLine();
            string[] weaponDesc = lineTwo.Split("|");
            string lineThree = WeaponReader.ReadLine();
            string[] weaponWeight = lineThree.Split(".");
            string lineFour = WeaponReader.ReadLine();
            string[] weaponValue = lineFour.Split(",");
            string lineFive = WeaponReader.ReadLine();
            string[] weaponDmg = lineFive.Split(">");

            Array dmgTypes = Enum.GetValues(typeof(DamageType));
            DamageType randomDmgType = (DamageType)dmgTypes.GetValue(rand.Next(dmgTypes.Length));

            randomWeapon = new Weapon(weaponName[rand.Next(0, weaponName.Length)], weaponDesc[rand.Next(0, weaponDesc.Length)],
                 double.Parse(weaponWeight[rand.Next(0, weaponWeight.Length)]), double.Parse(weaponValue[rand.Next(0, weaponValue.Length)]), 
                 int.Parse(weaponDmg[rand.Next(0, weaponDmg.Length)]), randomDmgType, rarity);

            WeaponReader.Close();
            return randomWeapon;
        }

        public static Weapon MakeRandomWeapon(RarityType rarity, bool isAccurate, string incriminates)
        {
            Weapon randomWeapon;
            StreamReader WeaponReader = new StreamReader("Item Files\\Weapons.txt");

            string lineOne = WeaponReader.ReadLine();
            string[] weaponName = lineOne.Split("-");
            string lineTwo = WeaponReader.ReadLine();
            string[] weaponDesc = lineTwo.Split("|");
            string lineThree = WeaponReader.ReadLine();
            string[] weaponWeight = lineThree.Split(".");
            string lineFour = WeaponReader.ReadLine();
            string[] weaponValue = lineFour.Split(",");
            string lineFive = WeaponReader.ReadLine();
            string[] weaponDmg = lineFive.Split(">");

            Array dmgTypes = Enum.GetValues(typeof(DamageType));
            DamageType randomDmgType = (DamageType)dmgTypes.GetValue(rand.Next(dmgTypes.Length));

            randomWeapon = new Weapon(weaponName[rand.Next(0, weaponName.Length)], weaponDesc[rand.Next(0, weaponDesc.Length)],
                 double.Parse(weaponWeight[rand.Next(0, weaponWeight.Length)]), double.Parse(weaponValue[rand.Next(0, weaponValue.Length)]),
                 int.Parse(weaponDmg[rand.Next(0, weaponDmg.Length)]), randomDmgType, rarity, incriminates, isAccurate);

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
