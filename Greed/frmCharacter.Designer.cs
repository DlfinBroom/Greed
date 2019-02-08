namespace Greed {
    partial class frmCharacter {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblPartyName = new System.Windows.Forms.Label();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.gbxClassSelection = new System.Windows.Forms.GroupBox();
            this.rbnRanger = new System.Windows.Forms.RadioButton();
            this.rbnRouge = new System.Windows.Forms.RadioButton();
            this.rbnCleric = new System.Windows.Forms.RadioButton();
            this.rbnMage = new System.Windows.Forms.RadioButton();
            this.rbnWarrior = new System.Windows.Forms.RadioButton();
            this.rbnKnight = new System.Windows.Forms.RadioButton();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.lblMaxHealth = new System.Windows.Forms.Label();
            this.txtDisplayMaxHealth = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDisplayDefense = new System.Windows.Forms.TextBox();
            this.lblDisplayDefense = new System.Windows.Forms.Label();
            this.txtDisplayMaxMana = new System.Windows.Forms.TextBox();
            this.lblMaxMana = new System.Windows.Forms.Label();
            this.gbxAttributes = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDisplayFaith = new System.Windows.Forms.TextBox();
            this.txtDisplayIntelligence = new System.Windows.Forms.TextBox();
            this.txtDisplayDexterity = new System.Windows.Forms.TextBox();
            this.txtDisplayStrength = new System.Windows.Forms.TextBox();
            this.lblDisplaySpeed = new System.Windows.Forms.Label();
            this.lblDisplayFaith = new System.Windows.Forms.Label();
            this.lblDisplayIntelligence = new System.Windows.Forms.Label();
            this.lblDisplayDexterity = new System.Windows.Forms.Label();
            this.lblDisplayStrength = new System.Windows.Forms.Label();
            this.lbxDisplayParty = new System.Windows.Forms.ListBox();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.gbxFinishCreation = new System.Windows.Forms.GroupBox();
            this.btnCreateParty = new System.Windows.Forms.Button();
            this.btnExitCreation = new System.Windows.Forms.Button();
            this.gbxClassSelection.SuspendLayout();
            this.gbxGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxAttributes.SuspendLayout();
            this.gbxFinishCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPartyName
            // 
            this.lblPartyName.AutoSize = true;
            this.lblPartyName.Location = new System.Drawing.Point(6, 25);
            this.lblPartyName.Name = "lblPartyName";
            this.lblPartyName.Size = new System.Drawing.Size(65, 13);
            this.lblPartyName.TabIndex = 0;
            this.lblPartyName.Text = "Party Name:";
            // 
            // txtPartyName
            // 
            this.txtPartyName.Enabled = false;
            this.txtPartyName.Location = new System.Drawing.Point(77, 22);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(127, 20);
            this.txtPartyName.TabIndex = 1;
            // 
            // gbxClassSelection
            // 
            this.gbxClassSelection.Controls.Add(this.rbnRanger);
            this.gbxClassSelection.Controls.Add(this.rbnRouge);
            this.gbxClassSelection.Controls.Add(this.rbnCleric);
            this.gbxClassSelection.Controls.Add(this.rbnMage);
            this.gbxClassSelection.Controls.Add(this.rbnWarrior);
            this.gbxClassSelection.Controls.Add(this.rbnKnight);
            this.gbxClassSelection.Location = new System.Drawing.Point(12, 30);
            this.gbxClassSelection.Name = "gbxClassSelection";
            this.gbxClassSelection.Size = new System.Drawing.Size(195, 102);
            this.gbxClassSelection.TabIndex = 2;
            this.gbxClassSelection.TabStop = false;
            this.gbxClassSelection.Text = "Classes:";
            // 
            // rbnRanger
            // 
            this.rbnRanger.AutoSize = true;
            this.rbnRanger.Location = new System.Drawing.Point(99, 68);
            this.rbnRanger.Name = "rbnRanger";
            this.rbnRanger.Size = new System.Drawing.Size(60, 17);
            this.rbnRanger.TabIndex = 5;
            this.rbnRanger.TabStop = true;
            this.rbnRanger.Text = "Ranger";
            this.rbnRanger.UseVisualStyleBackColor = true;
            // 
            // rbnRouge
            // 
            this.rbnRouge.AutoSize = true;
            this.rbnRouge.Location = new System.Drawing.Point(99, 44);
            this.rbnRouge.Name = "rbnRouge";
            this.rbnRouge.Size = new System.Drawing.Size(57, 17);
            this.rbnRouge.TabIndex = 4;
            this.rbnRouge.TabStop = true;
            this.rbnRouge.Text = "Rouge";
            this.rbnRouge.UseVisualStyleBackColor = true;
            // 
            // rbnCleric
            // 
            this.rbnCleric.AutoSize = true;
            this.rbnCleric.Location = new System.Drawing.Point(99, 20);
            this.rbnCleric.Name = "rbnCleric";
            this.rbnCleric.Size = new System.Drawing.Size(51, 17);
            this.rbnCleric.TabIndex = 3;
            this.rbnCleric.TabStop = true;
            this.rbnCleric.Text = "Cleric";
            this.rbnCleric.UseVisualStyleBackColor = true;
            // 
            // rbnMage
            // 
            this.rbnMage.AutoSize = true;
            this.rbnMage.Location = new System.Drawing.Point(7, 68);
            this.rbnMage.Name = "rbnMage";
            this.rbnMage.Size = new System.Drawing.Size(52, 17);
            this.rbnMage.TabIndex = 2;
            this.rbnMage.TabStop = true;
            this.rbnMage.Text = "Mage";
            this.rbnMage.UseVisualStyleBackColor = true;
            // 
            // rbnWarrior
            // 
            this.rbnWarrior.AutoSize = true;
            this.rbnWarrior.Location = new System.Drawing.Point(7, 44);
            this.rbnWarrior.Name = "rbnWarrior";
            this.rbnWarrior.Size = new System.Drawing.Size(59, 17);
            this.rbnWarrior.TabIndex = 1;
            this.rbnWarrior.TabStop = true;
            this.rbnWarrior.Text = "Warrior";
            this.rbnWarrior.UseVisualStyleBackColor = true;
            // 
            // rbnKnight
            // 
            this.rbnKnight.AutoSize = true;
            this.rbnKnight.Location = new System.Drawing.Point(7, 19);
            this.rbnKnight.Name = "rbnKnight";
            this.rbnKnight.Size = new System.Drawing.Size(55, 17);
            this.rbnKnight.TabIndex = 0;
            this.rbnKnight.TabStop = true;
            this.rbnKnight.Text = "Knight";
            this.rbnKnight.UseVisualStyleBackColor = true;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(12, 14);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(87, 13);
            this.lblCharacterName.TabIndex = 3;
            this.lblCharacterName.Text = "Character Name:";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Enabled = false;
            this.txtCharacterName.Location = new System.Drawing.Point(105, 11);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(102, 20);
            this.txtCharacterName.TabIndex = 4;
            // 
            // gbxGender
            // 
            this.gbxGender.Controls.Add(this.rbnFemale);
            this.gbxGender.Controls.Add(this.rbnMale);
            this.gbxGender.Location = new System.Drawing.Point(12, 138);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Size = new System.Drawing.Size(195, 50);
            this.gbxGender.TabIndex = 5;
            this.gbxGender.TabStop = false;
            this.gbxGender.Text = "Gender:";
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Location = new System.Drawing.Point(98, 20);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbnFemale.TabIndex = 1;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Location = new System.Drawing.Point(7, 20);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(48, 17);
            this.rbnMale.TabIndex = 0;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // lblMaxHealth
            // 
            this.lblMaxHealth.AutoSize = true;
            this.lblMaxHealth.Location = new System.Drawing.Point(6, 20);
            this.lblMaxHealth.Name = "lblMaxHealth";
            this.lblMaxHealth.Size = new System.Drawing.Size(48, 13);
            this.lblMaxHealth.TabIndex = 6;
            this.lblMaxHealth.Text = "Max HP:";
            // 
            // txtDisplayMaxHealth
            // 
            this.txtDisplayMaxHealth.Enabled = false;
            this.txtDisplayMaxHealth.Location = new System.Drawing.Point(60, 17);
            this.txtDisplayMaxHealth.Name = "txtDisplayMaxHealth";
            this.txtDisplayMaxHealth.Size = new System.Drawing.Size(34, 20);
            this.txtDisplayMaxHealth.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDisplayDefense);
            this.groupBox1.Controls.Add(this.lblDisplayDefense);
            this.groupBox1.Controls.Add(this.txtDisplayMaxMana);
            this.groupBox1.Controls.Add(this.lblMaxMana);
            this.groupBox1.Controls.Add(this.lblMaxHealth);
            this.groupBox1.Controls.Add(this.txtDisplayMaxHealth);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Base Stats:";
            // 
            // txtDisplayDefense
            // 
            this.txtDisplayDefense.Enabled = false;
            this.txtDisplayDefense.Location = new System.Drawing.Point(116, 42);
            this.txtDisplayDefense.Name = "txtDisplayDefense";
            this.txtDisplayDefense.Size = new System.Drawing.Size(34, 20);
            this.txtDisplayDefense.TabIndex = 10;
            // 
            // lblDisplayDefense
            // 
            this.lblDisplayDefense.AutoSize = true;
            this.lblDisplayDefense.Location = new System.Drawing.Point(21, 45);
            this.lblDisplayDefense.Name = "lblDisplayDefense";
            this.lblDisplayDefense.Size = new System.Drawing.Size(89, 13);
            this.lblDisplayDefense.TabIndex = 10;
            this.lblDisplayDefense.Text = "Starting Defense:";
            // 
            // txtDisplayMaxMana
            // 
            this.txtDisplayMaxMana.Enabled = false;
            this.txtDisplayMaxMana.Location = new System.Drawing.Point(155, 17);
            this.txtDisplayMaxMana.Name = "txtDisplayMaxMana";
            this.txtDisplayMaxMana.Size = new System.Drawing.Size(34, 20);
            this.txtDisplayMaxMana.TabIndex = 9;
            // 
            // lblMaxMana
            // 
            this.lblMaxMana.AutoSize = true;
            this.lblMaxMana.Location = new System.Drawing.Point(101, 20);
            this.lblMaxMana.Name = "lblMaxMana";
            this.lblMaxMana.Size = new System.Drawing.Size(49, 13);
            this.lblMaxMana.TabIndex = 8;
            this.lblMaxMana.Text = "Max MP:";
            // 
            // gbxAttributes
            // 
            this.gbxAttributes.Controls.Add(this.textBox1);
            this.gbxAttributes.Controls.Add(this.txtDisplayFaith);
            this.gbxAttributes.Controls.Add(this.txtDisplayIntelligence);
            this.gbxAttributes.Controls.Add(this.txtDisplayDexterity);
            this.gbxAttributes.Controls.Add(this.txtDisplayStrength);
            this.gbxAttributes.Controls.Add(this.lblDisplaySpeed);
            this.gbxAttributes.Controls.Add(this.lblDisplayFaith);
            this.gbxAttributes.Controls.Add(this.lblDisplayIntelligence);
            this.gbxAttributes.Controls.Add(this.lblDisplayDexterity);
            this.gbxAttributes.Controls.Add(this.lblDisplayStrength);
            this.gbxAttributes.Location = new System.Drawing.Point(213, 114);
            this.gbxAttributes.Name = "gbxAttributes";
            this.gbxAttributes.Size = new System.Drawing.Size(130, 153);
            this.gbxAttributes.TabIndex = 9;
            this.gbxAttributes.TabStop = false;
            this.gbxAttributes.Text = "Attributes:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 9;
            // 
            // txtDisplayFaith
            // 
            this.txtDisplayFaith.Enabled = false;
            this.txtDisplayFaith.Location = new System.Drawing.Point(74, 97);
            this.txtDisplayFaith.Name = "txtDisplayFaith";
            this.txtDisplayFaith.Size = new System.Drawing.Size(37, 20);
            this.txtDisplayFaith.TabIndex = 8;
            // 
            // txtDisplayIntelligence
            // 
            this.txtDisplayIntelligence.Enabled = false;
            this.txtDisplayIntelligence.Location = new System.Drawing.Point(74, 71);
            this.txtDisplayIntelligence.Name = "txtDisplayIntelligence";
            this.txtDisplayIntelligence.Size = new System.Drawing.Size(37, 20);
            this.txtDisplayIntelligence.TabIndex = 7;
            // 
            // txtDisplayDexterity
            // 
            this.txtDisplayDexterity.Enabled = false;
            this.txtDisplayDexterity.Location = new System.Drawing.Point(74, 45);
            this.txtDisplayDexterity.Name = "txtDisplayDexterity";
            this.txtDisplayDexterity.Size = new System.Drawing.Size(37, 20);
            this.txtDisplayDexterity.TabIndex = 6;
            // 
            // txtDisplayStrength
            // 
            this.txtDisplayStrength.Enabled = false;
            this.txtDisplayStrength.Location = new System.Drawing.Point(74, 19);
            this.txtDisplayStrength.Name = "txtDisplayStrength";
            this.txtDisplayStrength.Size = new System.Drawing.Size(37, 20);
            this.txtDisplayStrength.TabIndex = 5;
            // 
            // lblDisplaySpeed
            // 
            this.lblDisplaySpeed.AutoSize = true;
            this.lblDisplaySpeed.Location = new System.Drawing.Point(27, 126);
            this.lblDisplaySpeed.Name = "lblDisplaySpeed";
            this.lblDisplaySpeed.Size = new System.Drawing.Size(41, 13);
            this.lblDisplaySpeed.TabIndex = 4;
            this.lblDisplaySpeed.Text = "Speed:";
            // 
            // lblDisplayFaith
            // 
            this.lblDisplayFaith.AutoSize = true;
            this.lblDisplayFaith.Location = new System.Drawing.Point(35, 100);
            this.lblDisplayFaith.Name = "lblDisplayFaith";
            this.lblDisplayFaith.Size = new System.Drawing.Size(33, 13);
            this.lblDisplayFaith.TabIndex = 3;
            this.lblDisplayFaith.Text = "Faith:";
            // 
            // lblDisplayIntelligence
            // 
            this.lblDisplayIntelligence.AutoSize = true;
            this.lblDisplayIntelligence.Location = new System.Drawing.Point(4, 74);
            this.lblDisplayIntelligence.Name = "lblDisplayIntelligence";
            this.lblDisplayIntelligence.Size = new System.Drawing.Size(64, 13);
            this.lblDisplayIntelligence.TabIndex = 2;
            this.lblDisplayIntelligence.Text = "Intelligence:";
            // 
            // lblDisplayDexterity
            // 
            this.lblDisplayDexterity.AutoSize = true;
            this.lblDisplayDexterity.Location = new System.Drawing.Point(17, 48);
            this.lblDisplayDexterity.Name = "lblDisplayDexterity";
            this.lblDisplayDexterity.Size = new System.Drawing.Size(51, 13);
            this.lblDisplayDexterity.TabIndex = 1;
            this.lblDisplayDexterity.Text = "Dexterity:";
            // 
            // lblDisplayStrength
            // 
            this.lblDisplayStrength.AutoSize = true;
            this.lblDisplayStrength.Location = new System.Drawing.Point(18, 22);
            this.lblDisplayStrength.Name = "lblDisplayStrength";
            this.lblDisplayStrength.Size = new System.Drawing.Size(50, 13);
            this.lblDisplayStrength.TabIndex = 0;
            this.lblDisplayStrength.Text = "Strength:";
            // 
            // lbxDisplayParty
            // 
            this.lbxDisplayParty.Enabled = false;
            this.lbxDisplayParty.FormattingEnabled = true;
            this.lbxDisplayParty.Location = new System.Drawing.Point(213, 19);
            this.lbxDisplayParty.Name = "lbxDisplayParty";
            this.lbxDisplayParty.Size = new System.Drawing.Size(130, 95);
            this.lbxDisplayParty.TabIndex = 10;
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Location = new System.Drawing.Point(119, 273);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(110, 34);
            this.btnCreateCharacter.TabIndex = 11;
            this.btnCreateCharacter.Text = "Create Character";
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            // 
            // gbxFinishCreation
            // 
            this.gbxFinishCreation.Controls.Add(this.btnCreateParty);
            this.gbxFinishCreation.Controls.Add(this.lblPartyName);
            this.gbxFinishCreation.Controls.Add(this.txtPartyName);
            this.gbxFinishCreation.Location = new System.Drawing.Point(69, 313);
            this.gbxFinishCreation.Name = "gbxFinishCreation";
            this.gbxFinishCreation.Size = new System.Drawing.Size(212, 100);
            this.gbxFinishCreation.TabIndex = 12;
            this.gbxFinishCreation.TabStop = false;
            this.gbxFinishCreation.Text = "Create Party";
            // 
            // btnCreateParty
            // 
            this.btnCreateParty.Enabled = false;
            this.btnCreateParty.Location = new System.Drawing.Point(50, 48);
            this.btnCreateParty.Name = "btnCreateParty";
            this.btnCreateParty.Size = new System.Drawing.Size(110, 34);
            this.btnCreateParty.TabIndex = 13;
            this.btnCreateParty.Text = "Create Party";
            this.btnCreateParty.UseVisualStyleBackColor = true;
            // 
            // btnExitCreation
            // 
            this.btnExitCreation.Location = new System.Drawing.Point(287, 414);
            this.btnExitCreation.Name = "btnExitCreation";
            this.btnExitCreation.Size = new System.Drawing.Size(75, 33);
            this.btnExitCreation.TabIndex = 13;
            this.btnExitCreation.Text = "Exit";
            this.btnExitCreation.UseVisualStyleBackColor = true;
            // 
            // frmCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 453);
            this.Controls.Add(this.btnExitCreation);
            this.Controls.Add(this.gbxFinishCreation);
            this.Controls.Add(this.btnCreateCharacter);
            this.Controls.Add(this.lbxDisplayParty);
            this.Controls.Add(this.gbxAttributes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxGender);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.gbxClassSelection);
            this.Name = "frmCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Character Creation";
            this.gbxClassSelection.ResumeLayout(false);
            this.gbxClassSelection.PerformLayout();
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAttributes.ResumeLayout(false);
            this.gbxAttributes.PerformLayout();
            this.gbxFinishCreation.ResumeLayout(false);
            this.gbxFinishCreation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartyName;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.GroupBox gbxClassSelection;
        private System.Windows.Forms.RadioButton rbnRanger;
        private System.Windows.Forms.RadioButton rbnRouge;
        private System.Windows.Forms.RadioButton rbnCleric;
        private System.Windows.Forms.RadioButton rbnMage;
        private System.Windows.Forms.RadioButton rbnWarrior;
        private System.Windows.Forms.RadioButton rbnKnight;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.GroupBox gbxGender;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.Label lblMaxHealth;
        private System.Windows.Forms.TextBox txtDisplayMaxHealth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDisplayMaxMana;
        private System.Windows.Forms.Label lblMaxMana;
        private System.Windows.Forms.GroupBox gbxAttributes;
        private System.Windows.Forms.TextBox txtDisplayDefense;
        private System.Windows.Forms.Label lblDisplayDefense;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDisplayFaith;
        private System.Windows.Forms.TextBox txtDisplayIntelligence;
        private System.Windows.Forms.TextBox txtDisplayDexterity;
        private System.Windows.Forms.TextBox txtDisplayStrength;
        private System.Windows.Forms.Label lblDisplaySpeed;
        private System.Windows.Forms.Label lblDisplayFaith;
        private System.Windows.Forms.Label lblDisplayIntelligence;
        private System.Windows.Forms.Label lblDisplayDexterity;
        private System.Windows.Forms.Label lblDisplayStrength;
        private System.Windows.Forms.ListBox lbxDisplayParty;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.GroupBox gbxFinishCreation;
        private System.Windows.Forms.Button btnCreateParty;
        private System.Windows.Forms.Button btnExitCreation;
    }
}