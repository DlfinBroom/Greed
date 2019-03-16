using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    static class LootDB {
        public static List<Loot> GetLoot(int rarity, byte amount, byte area) {
            SqlConnection con = GreedDBCon.GetConnection();
            SqlCommand looCmd = new SqlCommand();
            looCmd.Connection = con;
            looCmd.CommandText = 
                "Select LootName, LootCategory, LootType " +
                "From Loot " +
                "Where Level is null and Name is not null";

            con.Open();

            SqlDataReader rdr = looCmd.ExecuteReader();
            List<Loot> loots = new List<Loot>();
            while (rdr.Read()) {
                Loot loo = new Loot();
                loo.Name = (string)rdr["LootName"];
                loo.LootCategory = (string)rdr["LootCategory"];
                loo.LootType = (string)rdr["LootType"];

                loots.Add(loo);
            }

            con.Dispose();
            return FilterLoot(loots, rarity, amount, area);
        }

        private static List<Loot> FilterLoot(List<Loot> DBLoot, int rarity, byte amount, byte area) {
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

        private static int RandomNum(int min, int max) {
            Random ran = new Random(DateTime.Now.Millisecond);
            int num = ran.Next(min, max);
            return num;
        }

        public static int[] AddCharLoot(Loot arm, Loot wep) {
            SqlConnection con = GreedDBCon.GetConnection();

            SqlCommand armCmd = new SqlCommand();
            armCmd.Connection = con;
            armCmd.CommandText =
                "Insert into " +
                "Loot(" +
                    "LootName, " +
                    "LootCategory, " +
                    "LootType, " +
                    "[Level], " +
                    "MagicStat, " +
                    "MagicStatIncre, " +
                    "Quality" +
                ") OUTPUT INSERTED.LootID " +
                "Values(" +
                    arm.Name + ", " +
                    arm.LootCategory + ", " +
                    arm.LootType + ", " +
                    arm.Level + ", " +
                    arm.MagicStat + ", " +
                    arm.MagicStatIncr + ", " +
                    arm.Quality +
                ")";
            SqlCommand wepCmd = new SqlCommand();
            wepCmd.Connection = con;
            wepCmd.CommandText =
                "Insert into " +
                "Loot(" +
                    "LootName, " +
                    "LootCategory, " +
                    "LootType, " +
                    "[Level], " +
                    "MagicStat, " +
                    "MagicStatIncre, " +
                    "Quality" +
                ") OUTPUT INSERTED.LootID" +
                "Values(" +
                    wep.Name + ", " +
                    wep.LootCategory + ", " +
                    wep.LootType + ", " +
                    wep.Level + ", " +
                    wep.MagicStat + ", " +
                    wep.MagicStatIncr + ", " +
                    wep.Quality +
                ")";
            con.Open();

            int[] LooIDs = new int[2];
            LooIDs[0] = (int)armCmd.ExecuteScalar();
            LooIDs[1] = (int)wepCmd.ExecuteScalar();

            con.Dispose();
            return LooIDs;
        }

        public static int[] AddLootList(List<Loot> loots) {
            SqlConnection con = GreedDBCon.GetConnection();

            SqlCommand looCmd = new SqlCommand();
            looCmd.Connection = con;

            int[] IDArray = new int[loots.Count];
            int counter = 0;

            con.Open();
            foreach (Loot loo in loots) {
                looCmd.CommandText =
                "Insert into " +
                "Loot(" +
                    "LootName, " +
                    "LootCategory, " +
                    "LootType, " +
                    "[Level], " +
                    "MagicStat, " +
                    "MagicStatIncre, " +
                    "Quality" +
                ") OUTPUT INSERTED.LootID " +
                "Values(" +
                    loo.Name + ", " +
                    loo.LootCategory + ", " +
                    loo.LootType + ", " +
                    loo.Level + ", " +
                    loo.MagicStat + ", " +
                    loo.MagicStatIncr +
                ")";
                IDArray[counter] = (int)looCmd.ExecuteScalar();
                counter++;
            }
            con.Dispose();
            return IDArray;
        }
    }
}
