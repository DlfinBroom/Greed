using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    class LootDB {
        public List<Loot> GetLoot(int rarity, byte amount, byte area) {
            throw new NotImplementedException();
            // get all weapons/armor that are null in DB
        }

        private List<Loot> FilterLoot(List<Loot> DBLoot, byte rarity, byte amount, byte area) {
            // Adds stuff to each peice of loot
            foreach(Loot loot in DBLoot) {
                if (rarity == 1) { loot.Quality = (byte)RandomNum(1, 3); }
                else if (rarity == 2) { loot.Quality = (byte)RandomNum(2, 4); }
                else { loot.Quality = (byte)RandomNum(3, 5); }

                if (area == 1) { loot.Level = (byte)RandomNum(1, 3); }
                else if (area == 2) { loot.Level = (byte)RandomNum(3, 5); }
                else { loot.Level = (byte)RandomNum(5, 7); }
            }
            // Only adds 2/3 of amount to bagoloot and returns that
            List<Loot> BagOLoot = new List<Loot>();
            for(int a = 0; a < amount; a++) {
                int rand = RandomNum(1, 3);
                if(rand == 1 || rand == 2) {
                    BagOLoot.Add(DBLoot[RandomNum(0, DBLoot.Count - 1)]);
                }
            }
            return BagOLoot;
        }

        private int RandomNum(int min, int max) {
            Random ran = new Random(DateTime.Now.Millisecond);
            int num = ran.Next(min, max);
            return num;
        }
    }
}
