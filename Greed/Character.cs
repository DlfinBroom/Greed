using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    /// <summary>
    /// Creates an object with the basic information about individual characters that are created by the user
    /// </summary>
    public class Character {
        
        //Characters Name assigned by user
        public string Name { get; set; }

        //Ex. Knight, Mage, Rouge, etc.
        public string Class { get; set; }

        //Ex. Male or Female
        public string Gender { get; set; }

        public byte MaxHealth { get; set; }

        public byte CurrHealth { get; set; }

        public byte? MaxMana { get; set; }

        public byte? CurrMana { get; set; }

        //Their starting defense before armor
        public byte Defense { get; set; }

        public byte Strength { get; set; }

        public byte Dexterity { get; set; }

        public byte Intelligence { get; set; }

        public byte Faith { get; set; }

        public byte Speed { get; set; }
        
        //Stores if the character is currently dead and needs to be revived
        public bool IsDead { get; set; }

        //How many times the character has died
        public byte TimesDied { get; set; }

        /// <summary>
        /// Constructor for a character object
        /// </summary>
        /// <param name="name">The Given name of the created object</param>
        /// <param name="charClass">The character class, EX. Knight, Mage, Rouge, etc.</param>
        /// <param name="gender">Ex. Male or Female</param>
        public Character(string name, string charClass, string gender)
        {
            Name = name;
            Class = charClass;
            Gender = gender;

            //Attributes based upon the Character class
            if ( charClass.Equals("Knight"))
            {
                MaxHealth = 100;
                CurrHealth = 100;
                Strength = 5;
                Dexterity = 2;
                Intelligence = 3;
                Faith = 3;
                Speed = 2;
            }
            else if ( charClass.Equals("Warrior") )
            {
                MaxHealth = 75;
                CurrHealth = 75;
                Strength = 6;
                Dexterity = 4;
                Intelligence = 3;
                Faith = 3;
                Speed = 5;
            }
            else if (charClass.Equals("Mage"))
            {
                MaxHealth = 75;
                CurrHealth = 75;
                MaxMana = 25;
                CurrMana = 25;
                Strength = 2;
                Dexterity = 3;
                Intelligence = 8;
                Faith = 2;
                Speed = 4;
            }
            else if (charClass.Equals("Cleric"))
            {
                MaxHealth = 75;
                CurrHealth = 75;
                MaxMana = 10;
                CurrMana = 10;
                Strength = 2;
                Dexterity = 3;
                Intelligence = 5;
                Faith = 6;
                Speed = 3;
            }
            else if (charClass.Equals("Rouge"))
            {
                MaxHealth = 50;
                CurrHealth = 50;
                Strength = 4;
                Dexterity = 4;
                Intelligence = 3;
                Faith = 2;
                Speed = 8;
            }
            else if (charClass.Equals("Ranger"))
            {
                MaxHealth = 50;
                CurrHealth = 50;
                Strength = 3;
                Dexterity = 6;
                Intelligence = 3;
                Faith = 3;
                Speed = 7;
            }

            IsDead = false;
            TimesDied = 0;
        }

        public string ToString()
        {
            return Name;
        }
    }
}
