using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    public class Loot {
        public string Name { get; set; }

        /// <summary>
        /// Determines if the loot is a weapon or armor
        /// </summary>
        public bool IsArmor { get; set; }

        /// <summary>
        /// Ex. Axe, Bow, Light armor, etc.
        /// </summary>
        public string LootType { get; set; }

        public byte Level { get; set; }

        public string MagicStat { get; set; }

        public byte MagicStatIncr { get; set; }

        /// <summary>
        /// How good of quality the weapons and armor are
        /// Ex. 5 levels, 0 - 4
        /// </summary>
        public byte Quality { get; set; }
    }
}
