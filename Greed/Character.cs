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
    }
}
