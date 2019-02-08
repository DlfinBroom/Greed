namespace Greed {
    partial class frmOpening {
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblGreed = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.btnLD = new System.Windows.Forms.Button();
            this.cbxSaveFiles = new System.Windows.Forms.ComboBox();
            this.lblLDError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(300, 200);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 35);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(300, 240);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 35);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Save";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(300, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Save";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(300, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(597, 374);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 75);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "icon of a wrench here";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 436);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(182, 13);
            this.lblCopyright.TabIndex = 5;
            this.lblCopyright.Text = "Trystin St.Louis | Daniel Ness @2019";
            // 
            // lblGreed
            // 
            this.lblGreed.AutoSize = true;
            this.lblGreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreed.Location = new System.Drawing.Point(180, 50);
            this.lblGreed.Name = "lblGreed";
            this.lblGreed.Size = new System.Drawing.Size(327, 113);
            this.lblGreed.TabIndex = 6;
            this.lblGreed.Text = "Greed";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Location = new System.Drawing.Point(196, 150);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(86, 13);
            this.lblSlogan.TabIndex = 7;
            this.lblSlogan.Text = "[put slogan here]";
            // 
            // btnLD
            // 
            this.btnLD.Location = new System.Drawing.Point(425, 240);
            this.btnLD.Name = "btnLD";
            this.btnLD.Size = new System.Drawing.Size(50, 35);
            this.btnLD.TabIndex = 8;
            this.btnLD.Text = "Load/Delete";
            this.btnLD.UseVisualStyleBackColor = true;
            this.btnLD.Visible = false;
            this.btnLD.Click += new System.EventHandler(this.btnLD_Click);
            // 
            // cbxSaveFiles
            // 
            this.cbxSaveFiles.FormattingEnabled = true;
            this.cbxSaveFiles.Location = new System.Drawing.Point(425, 280);
            this.cbxSaveFiles.Name = "cbxSaveFiles";
            this.cbxSaveFiles.Size = new System.Drawing.Size(75, 21);
            this.cbxSaveFiles.TabIndex = 9;
            this.cbxSaveFiles.Visible = false;
            this.cbxSaveFiles.SelectedIndexChanged += new System.EventHandler(this.cbxSaveFiles_SelectedIndexChanged);
            // 
            // lblLDError
            // 
            this.lblLDError.AutoSize = true;
            this.lblLDError.ForeColor = System.Drawing.Color.Red;
            this.lblLDError.Location = new System.Drawing.Point(425, 305);
            this.lblLDError.Name = "lblLDError";
            this.lblLDError.Size = new System.Drawing.Size(49, 13);
            this.lblLDError.TabIndex = 10;
            this.lblLDError.Text = "ErrorMsg";
            // 
            // frmOpening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblLDError);
            this.Controls.Add(this.cbxSaveFiles);
            this.Controls.Add(this.btnLD);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblGreed);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnNewGame);
            this.Name = "frmOpening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Greed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblGreed;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Button btnLD;
        private System.Windows.Forms.ComboBox cbxSaveFiles;
        private System.Windows.Forms.Label lblLDError;
    }
}

