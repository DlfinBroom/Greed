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
    public partial class frmCharacter : Form {
        public frmCharacter() {
            InitializeComponent();
        }

        private void frmCharacter_Load(object sender, EventArgs e)
        {
            rbnKnight_CheckedChanged(sender, e);
        }

        private void rbnKnight_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplayMaxHealth.Text = "100";
            txtDisplayMaxMana.Text = "0";
            txtDisplayDefense.Text = "";
            txtDisplayStrength.Text = "5";
            txtDisplayDexterity.Text = "2";
            txtDisplayIntelligence.Text = "3";
            txtDisplayFaith.Text = "3";
            txtDisplaySpeed.Text = "2";
        }

        private void rbnCleric_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplayMaxHealth.Text = "75";
            txtDisplayMaxMana.Text = "10";
            txtDisplayDefense.Text = "";
            txtDisplayStrength.Text = "2";
            txtDisplayDexterity.Text = "3";
            txtDisplayIntelligence.Text = "5";
            txtDisplayFaith.Text = "6";
            txtDisplaySpeed.Text = "3";
        }

        private void rbnWarrior_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplayMaxHealth.Text = "75";
            txtDisplayMaxMana.Text = "0";
            txtDisplayDefense.Text = "";
            txtDisplayStrength.Text = "6";
            txtDisplayDexterity.Text = "4";
            txtDisplayIntelligence.Text = "3";
            txtDisplayFaith.Text = "3";
            txtDisplaySpeed.Text = "5";
        }

        private void rbnRouge_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplayMaxHealth.Text = "50";
            txtDisplayMaxMana.Text = "0";
            txtDisplayDefense.Text = "";
            txtDisplayStrength.Text = "4";
            txtDisplayDexterity.Text = "4";
            txtDisplayIntelligence.Text = "3";
            txtDisplayFaith.Text = "2";
            txtDisplaySpeed.Text = "8";
        }

        private void rbnMage_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplayMaxHealth.Text = "75";
            txtDisplayMaxMana.Text = "25";
            txtDisplayDefense.Text = "";
            txtDisplayStrength.Text = "2";
            txtDisplayDexterity.Text = "3";
            txtDisplayIntelligence.Text = "8";
            txtDisplayFaith.Text = "2";
            txtDisplaySpeed.Text = "4";
        }

        private void rbnRanger_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplayMaxHealth.Text = "50";
            txtDisplayMaxMana.Text = "0";
            txtDisplayDefense.Text = "";
            txtDisplayStrength.Text = "3";
            txtDisplayDexterity.Text = "6";
            txtDisplayIntelligence.Text = "3";
            txtDisplayFaith.Text = "3";
            txtDisplaySpeed.Text = "7";
        }
    }
}
