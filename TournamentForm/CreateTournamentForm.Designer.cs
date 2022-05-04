namespace TournamentForm
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListBox tournamentPlayersListBox;
            System.Windows.Forms.ListBox prizesListBox;
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.newTournamentNameBox = new System.Windows.Forms.TextBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.newEntryFeeBox = new System.Windows.Forms.ComboBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewNameLabel = new System.Windows.Forms.LinkLabel();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.addPrizeButtpn = new System.Windows.Forms.Button();
            tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            prizesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 39;
            tournamentPlayersListBox.Location = new System.Drawing.Point(390, 117);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new System.Drawing.Size(401, 236);
            tournamentPlayersListBox.TabIndex = 16;
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 39;
            prizesListBox.Location = new System.Drawing.Point(390, 398);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new System.Drawing.Size(358, 158);
            prizesListBox.TabIndex = 18;
            // 
            // createTournamentLabel
            // 
            this.createTournamentLabel.AutoSize = true;
            this.createTournamentLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTournamentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createTournamentLabel.Location = new System.Drawing.Point(12, 9);
            this.createTournamentLabel.Name = "createTournamentLabel";
            this.createTournamentLabel.Size = new System.Drawing.Size(323, 39);
            this.createTournamentLabel.TabIndex = 3;
            this.createTournamentLabel.Text = "Create Tournament:";
            // 
            // newTournamentNameBox
            // 
            this.newTournamentNameBox.Location = new System.Drawing.Point(19, 117);
            this.newTournamentNameBox.Name = "newTournamentNameBox";
            this.newTournamentNameBox.Size = new System.Drawing.Size(365, 41);
            this.newTournamentNameBox.TabIndex = 9;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teamOneName.Location = new System.Drawing.Point(12, 75);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(289, 39);
            this.teamOneName.TabIndex = 8;
            this.teamOneName.Text = "Tournament Name:";
            // 
            // newEntryFeeBox
            // 
            this.newEntryFeeBox.FormattingEnabled = true;
            this.newEntryFeeBox.Location = new System.Drawing.Point(196, 189);
            this.newEntryFeeBox.Name = "newEntryFeeBox";
            this.newEntryFeeBox.Size = new System.Drawing.Size(188, 47);
            this.newEntryFeeBox.TabIndex = 11;
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 189);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(187, 39);
            this.entryFeeLabel.TabIndex = 10;
            this.entryFeeLabel.Text = "Entry Fee:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 47);
            this.comboBox1.TabIndex = 13;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectTeamLabel.Location = new System.Drawing.Point(17, 263);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(221, 39);
            this.selectTeamLabel.TabIndex = 12;
            this.selectTeamLabel.Text = "Select Team:";
            // 
            // createNewNameLabel
            // 
            this.createNewNameLabel.AutoSize = true;
            this.createNewNameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createNewNameLabel.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewNameLabel.LinkColor = System.Drawing.Color.Black;
            this.createNewNameLabel.Location = new System.Drawing.Point(230, 270);
            this.createNewNameLabel.Name = "createNewNameLabel";
            this.createNewNameLabel.Size = new System.Drawing.Size(154, 32);
            this.createNewNameLabel.TabIndex = 14;
            this.createNewNameLabel.TabStop = true;
            this.createNewNameLabel.Text = "create new";
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(383, 74);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(340, 39);
            this.tournamentPlayersLabel.TabIndex = 15;
            this.tournamentPlayersLabel.Text = "Tournament Players:";
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prizesLabel.Location = new System.Drawing.Point(383, 356);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(136, 39);
            this.prizesLabel.TabIndex = 17;
            this.prizesLabel.Text = "Prizes:";
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addTeamButton.Location = new System.Drawing.Point(115, 378);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(186, 51);
            this.addTeamButton.TabIndex = 19;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            // 
            // addPrizeButtpn
            // 
            this.addPrizeButtpn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addPrizeButtpn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPrizeButtpn.Location = new System.Drawing.Point(115, 458);
            this.addPrizeButtpn.Name = "addPrizeButtpn";
            this.addPrizeButtpn.Size = new System.Drawing.Size(186, 51);
            this.addPrizeButtpn.TabIndex = 20;
            this.addPrizeButtpn.Text = "Add Prize";
            this.addPrizeButtpn.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(803, 635);
            this.Controls.Add(this.addPrizeButtpn);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(prizesListBox);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(tournamentPlayersListBox);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.createNewNameLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.newEntryFeeBox);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.newTournamentNameBox);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.createTournamentLabel);
            this.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTournamentLabel;
        private System.Windows.Forms.TextBox newTournamentNameBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.ComboBox newEntryFeeBox;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewNameLabel;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button addPrizeButtpn;
    }
}