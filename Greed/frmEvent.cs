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
    public partial class tbxDialog : Form {
        public tbxDialog() {
            InitializeComponent();
            bool Continue = true;
            while (Continue == true) {
                EventStartDay();
                EventHeadOut();
                EventCombat();
                EventCombat();
                EventCombat();
                EventCombat();
                EventCombat();
                while (EventHeadBack() != true) {
                    EventNightCombat();
                }
                EventEndDay();
                // save progress
                Continue = EventContinue();
            }
            Close();
        }

        private bool EventContinue() {
            throw new NotImplementedException();
        }

        private void EventEndDay() {
            throw new NotImplementedException();
        }

        private void EventNightCombat() {
            throw new NotImplementedException();
        }

        private bool EventHeadBack() {
            throw new NotImplementedException();
        }

        private void EventCombat() {
            throw new NotImplementedException();
        }

        private void EventHeadOut() {
            throw new NotImplementedException();
        }

        private void EventStartDay() {
            throw new NotImplementedException();
        }

        private string GetInput(string[] options) {
            btnOption1.Text = options[1];
            btnOption2.Text = options[2];
            if (options.Length > 2) {
                btnOption3.Text = options[3];
            }
            if (options.Length > 3) {
                btnOption4.Text = options[4];
            }
            
        }

        private void btnBagOLoot_Click(object sender, EventArgs e) {
            frmLoot frmLoot = new frmLoot();
            frmLoot.Show();
        }
    }
}
