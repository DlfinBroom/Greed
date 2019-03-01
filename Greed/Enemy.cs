using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    public class Enemy {
        public string Name { get; set; }

        public byte MaxHealth { get; set; }

        public byte CurrHealth { get; set; }

        public byte Attack { get; set; }

        public byte Defence { get; set; }

        public byte Speed { get; set; }

        public bool IsDead { get; set; }

        public byte LootChance { get; set; }
    }
}
