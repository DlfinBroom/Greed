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

        List<Character> party = new List<Character>();

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

        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            //Assigning the Character Name
            string name = txtCharacterName.Text;
            if (name.Equals("") || name.Equals(null))
            {
                MessageBox.Show("Character must have a valid name");
                return;
            }

            //Asssigning the class variable
            string charClass = "";
            if (rbnKnight.Checked == true)
                charClass = "Knight";
            else if (rbnWarrior.Checked == true)
                charClass = "Warrior";
            else if (rbnMage.Checked == true)
                charClass = "Mage";
            else if (rbnCleric.Checked == true)
                charClass = "Cleric";
            else if (rbnRouge.Checked == true)
                charClass = "Rouge";
            else if (rbnRanger.Checked == true)
                charClass = "Ranger";

            //Assigning the gender variable
            string gender = "Male";
            if (rbnFemale.Checked == true)
                gender = "Female";

            //Creating the Character Object
            Character character = new Character(name, charClass, gender);

            //Adding Character object to party List
            party.Add(character);

            //Sending the character object to a new method
            DisplayCharacters();

            CheckNumCharacters();
        }

        private void DisplayCharacters()
        {
            //Clears the items in the list box so that it doesn't redisplay characters
            lbxDisplayParty.Items.Clear();

            //Display characters in listbox
            lbxDisplayParty.DisplayMember = "Name";

            foreach (Character c in party)
            {
                lbxDisplayParty.Items.Add(c);
            }
        }

        private void CheckNumCharacters()
        {
            if (lbxDisplayParty.Items.Count == 4)
            {
                txtCharacterName.Enabled = false;
                gbxClassSelection.Enabled = false;
                gbxGender.Enabled = false;
                btnCreateCharacter.Enabled = false;

                txtPartyName.Enabled = true;
                btnCreateParty.Enabled = true;
            }
        }
    }
}
