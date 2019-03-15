using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    class EnemyDB {
        public List<Enemy> GetEnemies(string area, int groupSize) {
            SqlConnection con = GreedDBCon.GetConnection();
            SqlCommand eneCmd = new SqlCommand();
            eneCmd.Connection = con;
            eneCmd.CommandText =
                "Select Name, MaxHealth, Attack, Defence, Speed, LootChance, Difficulty " +
                "From Enemy " +
                "Where Area == " + area + ";";

            con.Open();

            SqlDataReader rdr = eneCmd.ExecuteReader();

            List<Enemy> enemies = new List<Enemy>();
            while (rdr.Read()) {
                Enemy enem = new Enemy();
                enem.Name = (string)rdr["Name"];
                enem.MaxHealth = (byte)rdr["MaxHealth"];
                enem.CurrHealth = enem.MaxHealth;
                enem.Attack = (byte)rdr["Attack"];
                enem.Defence = (byte)rdr["Defence"];
                enem.Speed = (byte)rdr["Speed"];
                enem.IsDead = false;
                enem.LootChance = (byte)rdr["LootChance"];

                enemies.Add(enem);
            }

            con.Dispose();
            return FilterEnemies(enemies, groupSize);
        }

        private List<Enemy> FilterEnemies (List<Enemy> enemies, int groupSize) {
            List<Enemy> GroupOEnemies = new List<Enemy>();
            for(int a = 0; a < groupSize; a++) {
                GroupOEnemies.Add(enemies[RandomNum(0, enemies.Count - 1)]);
            }
            return GroupOEnemies;
        }

        private int RandomNum(int min, int max) {
            Random ran = new Random(DateTime.Now.Millisecond);
            int num = ran.Next(min, max);
            return num;
        }
    }
}
