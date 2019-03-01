using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    class SaveFile {
        // Party
        public string PartyName { get; set; }
        public Character Char1 { get; set; }
        public Character Char2 { get; set; }
        public Character Char3 { get; set; }
        public Character Char4 { get; set; }

        // Money
        public int Money { get; set; }
        public List<Loot> BagOLoot = new List<Loot>();

        // Consumables
        public byte? SHealPotion { get; set; }
        public byte? MHealPotion { get; set; }
        public byte? LHealPotion { get; set; }
        public byte? SManaPotion { get; set; }
        public byte? LManaPotion { get; set; }
        public byte? KillScroll { get; set; }
        public byte? DoomScroll { get; set; }
        public byte? WhiteFlag { get; set; }

        // Upgrades
        public byte Bagsize { get; set; }
        public bool Lanturn { get; set; }
        public bool Area2Item { get; set; }
        public bool Area3Item { get; set; }

        // New Game constructor
        public SaveFile( string partyName, 
            Character char1, Character char2, Character char3, Character char4) {

            Char1 = char1;
            Char2 = char2;
            Char3 = char3;
            Char4 = char4;
            Money = 0;
            Bagsize = 8;
            Lanturn = false;
            Area2Item = false;
            Area3Item = false;
        }
    }
}
