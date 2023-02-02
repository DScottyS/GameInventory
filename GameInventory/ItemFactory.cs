using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInventory
{
    public class ItemFactory
    {
       public Clue MakeRandomClue()
        {
            return new Clue();
        }

        public Clue MakeRandomClue(bool isAccurate, string incriminates)
        {
            return new Clue();
        }

        public Item MakeRandomItem()
        {
            return new Item();
        }

        public Weapon MakeRandomWeapon(RarityType rarity)
        {
            return new Weapon();
        }

        public Weapon MakeRandomWeapon(RarityType rarity, bool isAccurate, string incriminates)
        {
            return new Weapon();
        }
    }
}
