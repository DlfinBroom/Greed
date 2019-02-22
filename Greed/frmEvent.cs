using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greed {
    public partial class frmEvent : Form {
        private byte CombatCounter = 0;
        private string Path = "";

        public frmEvent() {
            InitializeComponent();
            string[] options = new string[4];
            options[0] = "Shop";
            options[1] = "Necromancer";
            options[2] = "Enchanter";
            options[3] = "Adventure out";
            AddDialog("We start out day just like any other, " +
                "In town, there is a old shop selling weapons, " +
                "armor, and any odds and ends he can find. " +
                "A necromancer runs a shop just down the road, who " +
                "claims can revive the dead, for a genourus fee of " +
                "cource, and a youngh wizard who specializes in " +
                "enchanting. Adventure calls out to you just beond " +
                "the main road.");
            InputDialog();

            Event(options);
            Hide();
        }

        private void AddDialog(string dialog) {
            tbxDialog.Text += dialog + System.Environment.NewLine;
        }
        private void InputDialog() {
            tbxDialog.Text += ">// ";
        }

        private void Event(string[] options) {
            btnOption1.Enabled = true;
            btnOption1.Text = options[0];
            btnOption2.Enabled = true;
            btnOption2.Text = options[1];
            btnOption3.Enabled = true;
            btnOption3.Text = options[2];
            btnOption4.Enabled = true;
            btnOption4.Text = options[3];
        }
        private void ClearOptions() {
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }

        private void btnBagOLoot_Click(object sender, EventArgs e) {
            frmLoot frmLoot = new frmLoot();
            frmLoot.Show();
        }

        private void btnOption1_Click(object sender, EventArgs e) {
            OptionBtnClicked(btnOption1.Text);
        }
        private void btnOption2_Click(object sender, EventArgs e) {
            OptionBtnClicked(btnOption2.Text);
        }
        private void btnOption3_Click(object sender, EventArgs e) {
            OptionBtnClicked(btnOption3.Text);
        }
        private void btnOption4_Click(object sender, EventArgs e) {
            OptionBtnClicked(btnOption4.Text);
        }

        private void OptionBtnClicked(string btnText) {
            string Shop = "Shop";
            string Necromancer = "Necromancer";
            string Enchanter = "Encahnter";
            string AdventureOut = "Adventure out of town";
            string Path1 = "Feild";
            string Path2 = "Forest";
            string Path3 = "Mountain Path";
            string Battle = "Battle!";
            string NightBattle = "Fight!";
            string HeadBack = "Head Back";
            string Rest = "Rest(25g)";
            string NotRest = "Sleep is for the weak!";
            string Yeah = "Yeah";
            string Naw = "Naw.";

            string[] options = new string[4];
            // Event: Start Town
            if (btnText == Shop) {
                AddDialog(Shop + " >");
                AddDialog("ERROR: NOT IMPLAMENTED YET");
                AddDialog(">// Return to Town >");
                    options[0] = Shop;
                    options[1] = Necromancer;
                    options[2] = Enchanter;
                    options[3] = AdventureOut;
            }
            else if (btnText == Necromancer) {
                AddDialog(Necromancer + " >");
                AddDialog("ERROR: NOT IMPLAMENTED YET");
                AddDialog(">// Return to Town >");
                    options[0] = Shop;
                    options[1] = Necromancer;
                    options[2] = Enchanter;
                    options[3] = AdventureOut;
            }
            else if (btnText == Enchanter) {
                AddDialog(Enchanter + " >");
                AddDialog("ERROR: NOT IMPLAMENTED YET");
                AddDialog(">// Return to Town >");
                    options[0] = Shop;
                    options[1] = Necromancer;
                    options[2] = Enchanter;
                    options[3] = AdventureOut;
            }
            else if (btnText == AdventureOut) {
                AddDialog(AdventureOut + " >");
                AddDialog("Where will you and your party go today?");
                    options[0] = Path1;
                    options[1] = Path2;
                    options[2] = Path3;
            }
            // Event: Pick Path
            else if (btnText == Path1) {
                AddDialog(Path1 + " >");
                    options[0] = Battle;
                    options[1] = HeadBack;
                    Path = "Path1";
            }
            else if (btnText == Path2) {
                AddDialog(Path2 + " >");
                    options[0] = Battle;
                    options[1] = HeadBack;
                    Path = "Path2";
            }
            else if (btnText == Path3) {
                AddDialog(Path2 + " >");
                    options[0] = Battle;
                    options[1] = HeadBack;
                    Path = "Path3";
            }
            // Event: Combat!
            else if (btnText == Battle) {
                AddDialog(Battle + " >");
                // ToDo: Start combat here
                CombatCounter++;
                if (CombatCounter <= 4) {
                    options[0] = Battle;
                    options[1] = HeadBack;
                }
                else {
                    options[0] = NightBattle;
                    options[1] = HeadBack;
                }
            }
            else if (btnText == HeadBack) {
                AddDialog(HeadBack + " >");
                    options[0] = Rest;
                    options[1] = NotRest;
            }
            else if (btnText == NightBattle) {
                AddDialog(NightBattle + " >");
                // ToDo: Start combat here
                    options[0] = NightBattle;
                    options[1] = HeadBack;
            }
            // Event: End Town
            else if (btnText == Rest) {
                // Reset party health
                // gold = gold - 25
                AddDialog(Rest + " >");
                    options[0] = Yeah;
                    options[1] = Naw;
            }
            else if (btnText == NotRest) {
                AddDialog(NotRest + " >");
                    options[0] = Yeah;
                    options[1] = Naw;
            }
            // Event: Repeat?
            else if (btnText == Yeah) {
                AddDialog(Yeah + " >");
                    options[0] = Shop;
                    options[1] = Necromancer;
                    options[2] = Enchanter;
                    options[3] = AdventureOut;
            }
            else if (btnText == Naw) {
                AddDialog(Naw + " >");
                return;
            }
            else {
                AddDialog("wat >");
                options[0] = btnOption1.Text;
                options[1] = btnOption2.Text;
                options[2] = btnOption3.Text;
                options[3] = btnOption4.Text;
            }
            InputDialog();
            Event(options);
            Thread.Sleep(100);
        }
    }
}
