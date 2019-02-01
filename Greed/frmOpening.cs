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
    public partial class frmOpening : Form {
        public frmOpening() {
            InitializeComponent();
            populateSaveFiles();
            populateSlogan();
            hideLD();
            lblCopyright.Text = 
                "Trystin St.Louis | Daniel Ness @" + DateTime.Now.Year.ToString();
        }

        private void hideLD() {
            btnLD.Visible = false;
            lblLDError.Visible = false;
            cbxSaveFiles.Visible = false;
        }

        // Populate methods
        private void populateSaveFiles() {
            // ToDo: make this method
        }
        private void populateSlogan() {
            // ToDo: make this method
        }

        private void btnNewGame_Click(object sender, EventArgs e) {
            frmCharacter frmChar = new frmCharacter();
            frmChar.Show();
            //frmChar.DialogResult;
        }

        // Load/Delete methods
        private void btnLoad_Click(object sender, EventArgs e) {
            btnLD.Text = "Load";
            btnLD.Visible = true;
            btnLD.Location = 
                new Point(btnLD.Location.X, btnLoad.Location.Y);
            cbxSaveFiles.Visible = true;
            cbxSaveFiles.Location = 
                new Point(btnLD.Location.X, btnLD.Location.Y + 41);
            lblLDError.Visible = false;
            lblLDError.Location =
                new Point(cbxSaveFiles.Location.X, cbxSaveFiles.Location.Y + 25);
            populateSaveFiles();
        }
        private void btnDelete_Click(object sender, EventArgs e) {
            btnLD.Text = "Delete";
            btnLD.Visible = true;
            btnLD.Location =
                new Point(btnLD.Location.X, btnDelete.Location.Y);
            cbxSaveFiles.Visible = true;
            cbxSaveFiles.Location =
                new Point(btnLD.Location.X, btnLD.Location.Y + 41);
            lblLDError.Visible = false;
            lblLDError.Location =
                new Point(cbxSaveFiles.Location.X, cbxSaveFiles.Location.Y + 25);
            populateSaveFiles();
        }

        // LD stands for Load/Delete
        private void btnLD_Click(object sender, EventArgs e) {
            if (cbxSaveFiles.SelectedItem != null) {
                if (btnLD.Text == "Load") {
                    // make new save file that == cbxSaveFile.SelectedItem
                    // pass that save file to frmEve
                    frmEvent frmEve = new frmEvent();
                    frmEve.Show();
                    Hide();
                }
                else {
                    // ToDo: finish this
                }
            }
            else {
                lblLDError.Text =
                    "Please select a save file to " + btnLD.Text.ToLower() + ".";
                lblLDError.Visible = true;
                //}
            }
        }

        private void cbxSaveFiles_SelectedIndexChanged(object sender, EventArgs e) {
            lblLDError.Visible = false;
        }

        // Joke and Close buttons
        private void btnOptions_Click(object sender, EventArgs e) {
            MessageBox.Show("This button is a joke, sorry but it does nothing");
        }
        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}