using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greed {
    public partial class frmEvent : Form {
        private string OPTION_PICKED = "";

        public frmEvent() {
            InitializeComponent();
            bool Continue = true;
            while (Continue == true) {
                EventStartDay();
                System.Threading.Thread.Sleep(1500);
                EventHeadOut();
                System.Threading.Thread.Sleep(1500);
                EventCombat();
                System.Threading.Thread.Sleep(1500);
                EventCombat();
                System.Threading.Thread.Sleep(1500);
                EventCombat();
                System.Threading.Thread.Sleep(1500);
                EventCombat();
                System.Threading.Thread.Sleep(1500);
                EventCombat();
                System.Threading.Thread.Sleep(1500);
                while (EventHeadBack() != true) {
                    System.Threading.Thread.Sleep(1500);
                    EventNightCombat();
                }
                System.Threading.Thread.Sleep(1500);
                EventEndDay();
                System.Threading.Thread.Sleep(1500);
                // save progress
                Continue = EventContinue();
            }
            Close();
        }

        private bool EventContinue() {
            AddDialog("Contenue playing?");
            string[] options = new string[] { "Yeah", "Naw" };
            PopulateOptions(options);
            while (1 == 1) {
                if (OPTION_PICKED == options[0]) {
                    return true;
                }
                if (OPTION_PICKED == options[1]) {
                    return false;
                }
                System.Threading.Thread.Sleep(2500);
            }
        }
        private void EventEndDay() {
            AddDialog("End Day");
            string[] options = new string[] { "Rest for the night(25g)", "somthing", "another" };
            PopulateOptions(options);
            while (1 == 1) {
                if (OPTION_PICKED == options[0]) {
                    return;
                }
                if (OPTION_PICKED == options[1]) {
                    return;
                }
                if (OPTION_PICKED == options[2]) {
                    return;
                }
                System.Threading.Thread.Sleep(2500);
            }
        }
        private void EventNightCombat() {
            AddDialog("Night Combat");
            string[] options = new string[] { "Start", "Head back to town" };
            PopulateOptions(options);
            while (1 == 1) {
                if (OPTION_PICKED == options[0]) {
                    return;
                }
                if (OPTION_PICKED == options[1]) {
                    return;
                }
                if (OPTION_PICKED == options[2]) {
                    return;
                }
                if (OPTION_PICKED == options[3]) {
                    return;
                }
                System.Threading.Thread.Sleep(2500);
            }
        }
        private bool EventHeadBack() {
            AddDialog("Back to town?");
            string[] options = new string[] { "Naw", "Sure" };
            PopulateOptions(options);
            while (1 == 1) {
                if (OPTION_PICKED == options[0]) {
                    return false;
                }
                if (OPTION_PICKED == options[1]) {
                    return true;
                }
                System.Threading.Thread.Sleep(2500);
            }
        }
        private void EventCombat() {
            AddDialog("Combat");
            string[] options = new string[] { "start", "naw" };
            PopulateOptions(options);
            while (1 == 1) {
                if (OPTION_PICKED == options[0]) {
                    return;
                }
                if (OPTION_PICKED == options[1]) {
                    return;
                }
                System.Threading.Thread.Sleep(2500);
            }
        }
        private void EventHeadOut() {
            AddDialog("Heading out");
            string[] options = new string[] { "place1", "place2", "place3" };
            PopulateOptions(options);
            while (1 == 1) {
                if (OPTION_PICKED == options[0]) {
                    return;
                }
                if (OPTION_PICKED == options[1]) {
                    return;
                }
                if (OPTION_PICKED == options[2]) {
                    return;
                }
                System.Threading.Thread.Sleep(2500);
            }
        }
        private void EventStartDay() {
            AddDialog("Start Day");
            string[] options = new string[] { "Shop", "Necromancer", "Enchanter", "Adventure" };
            PopulateOptions(options);
            while (1 == 1) {
                if(OPTION_PICKED == options[0]) {
                    return;
                }
                if (OPTION_PICKED == options[1]) {
                    return;
                }
                if (OPTION_PICKED == options[2]) {
                    return;
                }
                if (OPTION_PICKED == options[3]) {
                    return;
                }
                System.Threading.Thread.Sleep(2500);
            }
        }

        private void AddDialog(string dialog) {
            tbxDialog.Text += "/n" + dialog;
        }

        private void PopulateOptions(string[] options) {
            btnOption1.Enabled = true;
            btnOption1.Text = options[0];
            btnOption2.Enabled = true;
            btnOption2.Text = options[1];
            if (options.Length > 2) {
                btnOption3.Enabled = true;
                btnOption3.Text = options[2];
            }
            if (options.Length == 4) {
                btnOption4.Enabled = true;
                btnOption4.Text = options[3];
            }
        }
        private void ClearOptions() {
            btnOption1.Enabled = false;
            btnOption1.Text = "";
            btnOption2.Enabled = false;
            btnOption2.Text = "";
            btnOption3.Enabled = false;
            btnOption3.Text = "";
            btnOption4.Enabled = false;
            btnOption4.Text = "";
        }

        private void btnBagOLoot_Click(object sender, EventArgs e) {
            frmLoot frmLoot = new frmLoot();
            frmLoot.Show();
        }

        private void btnOption1_Click(object sender, EventArgs e) {
            OPTION_PICKED = btnOption1.Text;
            ClearOptions();
        }
        private void btnOption2_Click(object sender, EventArgs e) {
            OPTION_PICKED = btnOption2.Text;
            ClearOptions();
        }
        private void btnOption3_Click(object sender, EventArgs e) {
            OPTION_PICKED = btnOption3.Text;
            ClearOptions();
        }
        private void btnOption4_Click(object sender, EventArgs e) {
            OPTION_PICKED = btnOption4.Text;
            ClearOptions();
        }
    }
}
