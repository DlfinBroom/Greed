using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    static class CharacterDB {
        public static int[] AddPartyCharacters(Character cha1, 
                                               Character cha2,
                                               Character cha3,
                                               Character cha4) {
            int[] Char1LootID = LootDB.AddCharLoot(cha1.EquipedArmor, cha1.EquipedWeapon);
            int[] Char2LootID = LootDB.AddCharLoot(cha2.EquipedArmor, cha2.EquipedWeapon);
            int[] Char3LootID = LootDB.AddCharLoot(cha3.EquipedArmor, cha3.EquipedWeapon);
            int[] Char4LootID = LootDB.AddCharLoot(cha4.EquipedArmor, cha4.EquipedWeapon);
            SqlConnection con = GreedDBCon.GetConnection();

            #region Character1
            SqlCommand cha1Cmd = new SqlCommand();
            cha1Cmd.Connection = con;
            cha1Cmd.CommandText =
                "Insert into " +
                "Character(" +
                    "[Name], " +
                    "Class, " +
                    "Gender, " +
                    "MaxHealth, " +
                    "CurrHealth, " +
                    "MaxMana, " +
                    "CurrMana, " +
                    "IsDead, " +
                    "TimesDied, " +
                    "EquipArmorID, " +
                    "EquipWeaponID" +
                ") OUTPUT INSERTED.CharID " +
                "Values(" +
                    cha1.Name + ", " +
                    cha1.Class + ", " +
                    cha1.Gender + ", " +
                    cha1.MaxHealth + ", " +
                    cha1.CurrHealth + ", " +
                    cha1.MaxMana + ", " +
                    cha1.CurrMana + ", " +
                    cha1.IsDead + ", " +
                    cha1.TimesDied + ", " +
                    Char1LootID[0] + ", " +
                    Char1LootID[1] +
                ")";
            #endregion

            #region Character2
            SqlCommand cha2Cmd = new SqlCommand();
            cha2Cmd.Connection = con;
            cha2Cmd.CommandText =
                "Insert into " +
                "Character(" +
                    "[Name], " +
                    "Class, " +
                    "Gender, " +
                    "MaxHealth, " +
                    "CurrHealth, " +
                    "MaxMana, " +
                    "CurrMana, " +
                    "IsDead, " +
                    "TimesDied, " +
                    "EquipArmorID, " +
                    "EquipWeaponID" +
                ") OUTPUT INSERTED.CharID " +
                "Values(" +
                    cha2.Name + ", " +
                    cha2.Class + ", " +
                    cha2.Gender + ", " +
                    cha2.MaxHealth + ", " +
                    cha2.CurrHealth + ", " +
                    cha2.MaxMana + ", " +
                    cha2.CurrMana + ", " +
                    cha2.IsDead + ", " +
                    cha2.TimesDied + ", " +
                    Char2LootID[0] + ", " +
                    Char2LootID[1] +
                ")";
            #endregion

            #region Character3
            SqlCommand cha3Cmd = new SqlCommand();
            cha3Cmd.Connection = con;
            cha3Cmd.CommandText =
                "Insert into " +
                "Character(" +
                    "[Name], " +
                    "Class, " +
                    "Gender, " +
                    "MaxHealth, " +
                    "CurrHealth, " +
                    "MaxMana, " +
                    "CurrMana, " +
                    "IsDead, " +
                    "TimesDied, " +
                    "EquipArmorID, " +
                    "EquipWeaponID" +
                ") OUTPUT INSERTED.CharID " +
                "Values(" +
                    cha3.Name + ", " +
                    cha3.Class + ", " +
                    cha3.Gender + ", " +
                    cha3.MaxHealth + ", " +
                    cha3.CurrHealth + ", " +
                    cha3.MaxMana + ", " +
                    cha3.CurrMana + ", " +
                    cha3.IsDead + ", " +
                    cha3.TimesDied + ", " +
                    Char3LootID[0] + ", " +
                    Char3LootID[1] +
                ")";
            #endregion

            #region Character4
            SqlCommand cha4Cmd = new SqlCommand();
            cha4Cmd.Connection = con;
            cha4Cmd.CommandText =
                "Insert into " +
                "Character(" +
                    "[Name], " +
                    "Class, " +
                    "Gender, " +
                    "MaxHealth, " +
                    "CurrHealth, " +
                    "MaxMana, " +
                    "CurrMana, " +
                    "IsDead, " +
                    "TimesDied, " +
                    "EquipArmorID, " +
                    "EquipWeaponID" +
                ") OUTPUT INSERTED.CharID " +
                "Values(" +
                    cha4.Name + ", " +
                    cha4.Class + ", " +
                    cha4.Gender + ", " +
                    cha4.MaxHealth + ", " +
                    cha4.CurrHealth + ", " +
                    cha4.MaxMana + ", " +
                    cha4.CurrMana + ", " +
                    cha4.IsDead + ", " +
                    cha4.TimesDied + ", " +
                    Char4LootID[0] + ", " +
                    Char4LootID[1] +
                ")";
            #endregion

            con.Open();

            int[] charIDs = new int[4];
            charIDs[0] = (int)cha1Cmd.ExecuteScalar();
            charIDs[1] = (int)cha2Cmd.ExecuteScalar();
            charIDs[2] = (int)cha3Cmd.ExecuteScalar();
            charIDs[3] = (int)cha4Cmd.ExecuteScalar();

            con.Dispose();
            return charIDs;
        }
    }
}
