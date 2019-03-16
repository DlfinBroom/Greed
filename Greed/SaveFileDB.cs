using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greed {
    class SaveFileDB {
        public bool AddSaveFile(SaveFile sav) {
            int[] CharIDs = CharacterDB.AddPartyCharacters(sav.Char1, sav.Char2, sav.Char3, sav.Char4);
            SqlConnection con = GreedDBCon.GetConnection();

            SqlCommand savCmd = new SqlCommand();
            savCmd.Connection = con;
            savCmd.CommandText =
                "Insert into " +
                "SaveFile(" +
                    "PartyName, " +
                    "Char1ID, " +
                    "Char2ID, " +
                    "Char3ID, " +
                    "Char4ID, " +
                    "[Money], " +
                    "SHealPotion, " +
                    "MHealPotion, " +
                    "LHealPotion, " +
                    "SManaPotion, " +
                    "LManaPotion, " +
                    "KillScroll, " +
                    "DoomScroll, " +
                    "WhiteFlag, " +
                    "BagSize, " +
                    "Lanturn, " +
                    "Area2Item, " +
                    "Area3Item " +
                "Values(" +
                    sav.PartyName + ", " +
                    CharIDs[0] + ", " +
                    CharIDs[1] + ", " +
                    CharIDs[2] + ", " +
                    CharIDs[3] + ", " +
                    sav.Money + ", " +
                    sav.SHealPotion + ", " +
                    sav.MHealPotion + ", " +
                    sav.LHealPotion + ", " +
                    sav.SManaPotion + ", " +
                    sav.LManaPotion + ", " +
                    sav.KillScroll + ", " +
                    sav.DoomScroll + ", " +
                    sav.WhiteFlag + ", " +
                    sav.Bagsize + ", " +
                    sav.Lanturn + ", " +
                    sav.Area2Item + ", " +
                    sav.Area3Item +
                ")";
            con.Open();
            try {
                savCmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e) {
                return false;
            }
            finally {
                con.Dispose();
            }
        }
    }
}
