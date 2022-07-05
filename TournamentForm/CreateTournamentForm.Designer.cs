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
            this.createTournamentLabel = new System.Windows.Forms.Label();
            this.newTournamentValue = new System.Windows.Forms.TextBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.newEntryFeeValue = new System.Windows.Forms.ComboBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createNewTeamLabel = new System.Windows.Forms.LinkLabel();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.addPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListBox = new System.Windows.Forms.ListBox();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedPlayersButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizesButton = new System.Windows.Forms.Button();
            this.createNewTournamentButton = new System.Windows.Forms.Button();
            this.danCheckBox = new System.Windows.Forms.CheckBox();
            this.ryuCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            // newTournamentValue
            // 
            this.newTournamentValue.Location = new System.Drawing.Point(19, 117);
            this.newTournamentValue.Name = "newTournamentValue";
            this.newTournamentValue.Size = new System.Drawing.Size(365, 41);
            this.newTournamentValue.TabIndex = 9;
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
            // newEntryFeeValue
            // 
            this.newEntryFeeValue.FormattingEnabled = true;
            this.newEntryFeeValue.Location = new System.Drawing.Point(196, 189);
            this.newEntryFeeValue.Name = "newEntryFeeValue";
            this.newEntryFeeValue.Size = new System.Drawing.Size(188, 47);
            this.newEntryFeeValue.TabIndex = 11;
            this.newEntryFeeValue.Text = "0";
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
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(24, 305);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(360, 47);
            this.selectTeamDropDown.TabIndex = 13;
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
            // createNewTeamLabel
            // 
            this.createNewTeamLabel.AutoSize = true;
            this.createNewTeamLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createNewTeamLabel.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewTeamLabel.LinkColor = System.Drawing.Color.Black;
            this.createNewTeamLabel.Location = new System.Drawing.Point(230, 270);
            this.createNewTeamLabel.Name = "createNewTeamLabel";
            this.createNewTeamLabel.Size = new System.Drawing.Size(154, 32);
            this.createNewTeamLabel.TabIndex = 14;
            this.createNewTeamLabel.TabStop = true;
            this.createNewTeamLabel.Text = "create new";
            this.createNewTeamLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLabel_LinkClicked);
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(383, 75);
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
            this.addTeamButton.Location = new System.Drawing.Point(86, 358);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(249, 106);
            this.addTeamButton.TabIndex = 19;
            this.addTeamButton.Text = "Add Team From Dropdown";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click_1);
            // 
            // addPrizeButton
            // 
            this.addPrizeButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addPrizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPrizeButton.Location = new System.Drawing.Point(766, 506);
            this.addPrizeButton.Name = "addPrizeButton";
            this.addPrizeButton.Size = new System.Drawing.Size(186, 92);
            this.addPrizeButton.TabIndex = 20;
            this.addPrizeButton.Text = "Create Prize";
            this.addPrizeButton.UseVisualStyleBackColor = false;
            this.addPrizeButton.Click += new System.EventHandler(this.addPrizeButton_Click);
            // 
            // tournamentTeamsListBox
            // 
            this.tournamentTeamsListBox.FormattingEnabled = true;
            this.tournamentTeamsListBox.ItemHeight = 39;
            this.tournamentTeamsListBox.Location = new System.Drawing.Point(391, 117);
            this.tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            this.tournamentTeamsListBox.Size = new System.Drawing.Size(369, 238);
            this.tournamentTeamsListBox.TabIndex = 21;
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 39;
            this.prizesListBox.Location = new System.Drawing.Point(390, 399);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(370, 199);
            this.prizesListBox.TabIndex = 22;
            // 
            // removeSelectedPlayersButton
            // 
            this.removeSelectedPlayersButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.removeSelectedPlayersButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeSelectedPlayersButton.Location = new System.Drawing.Point(766, 263);
            this.removeSelectedPlayersButton.Name = "removeSelectedPlayersButton";
            this.removeSelectedPlayersButton.Size = new System.Drawing.Size(186, 92);
            this.removeSelectedPlayersButton.TabIndex = 23;
            this.removeSelectedPlayersButton.Text = "Remove Selected";
            this.removeSelectedPlayersButton.UseVisualStyleBackColor = false;
            this.removeSelectedPlayersButton.Click += new System.EventHandler(this.removeSelectedPlayersButton_Click_1);
            // 
            // removeSelectedPrizesButton
            // 
            this.removeSelectedPrizesButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.removeSelectedPrizesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeSelectedPrizesButton.Location = new System.Drawing.Point(766, 399);
            this.removeSelectedPrizesButton.Name = "removeSelectedPrizesButton";
            this.removeSelectedPrizesButton.Size = new System.Drawing.Size(186, 92);
            this.removeSelectedPrizesButton.TabIndex = 24;
            this.removeSelectedPrizesButton.Text = "Remove Selected";
            this.removeSelectedPrizesButton.UseVisualStyleBackColor = false;
            this.removeSelectedPrizesButton.Click += new System.EventHandler(this.removeSelectedPrizesButton_Click_1);
            // 
            // createNewTournamentButton
            // 
            this.createNewTournamentButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createNewTournamentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createNewTournamentButton.Location = new System.Drawing.Point(314, 617);
            this.createNewTournamentButton.Name = "createNewTournamentButton";
            this.createNewTournamentButton.Size = new System.Drawing.Size(326, 92);
            this.createNewTournamentButton.TabIndex = 25;
            this.createNewTournamentButton.Text = "Create Tournament";
            this.createNewTournamentButton.UseVisualStyleBackColor = false;
            this.createNewTournamentButton.Click += new System.EventHandler(this.createNewTournamentButton_Click);
            // 
            // danCheckBox
            // 
            this.danCheckBox.AutoSize = true;
            this.danCheckBox.Location = new System.Drawing.Point(766, 115);
            this.danCheckBox.Name = "danCheckBox";
            this.danCheckBox.Size = new System.Drawing.Size(87, 43);
            this.danCheckBox.TabIndex = 26;
            this.danCheckBox.Text = "Dan";
            this.danCheckBox.UseVisualStyleBackColor = true;
            this.danCheckBox.CheckedChanged += new System.EventHandler(this.danCheckBox_CheckedChanged);
            // 
            // ryuCheckBox
            // 
            this.ryuCheckBox.AutoSize = true;
            this.ryuCheckBox.Location = new System.Drawing.Point(766, 164);
            this.ryuCheckBox.Name = "ryuCheckBox";
            this.ryuCheckBox.Size = new System.Drawing.Size(87, 43);
            this.ryuCheckBox.TabIndex = 27;
            this.ryuCheckBox.Text = "Kyu";
            this.ryuCheckBox.UseVisualStyleBackColor = true;
            this.ryuCheckBox.CheckedChanged += new System.EventHandler(this.ryuCheckBox_CheckedChanged);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(962, 736);
            this.Controls.Add(this.ryuCheckBox);
            this.Controls.Add(this.danCheckBox);
            this.Controls.Add(this.createNewTournamentButton);
            this.Controls.Add(this.removeSelectedPrizesButton);
            this.Controls.Add(this.removeSelectedPlayersButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentTeamsListBox);
            this.Controls.Add(this.addPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.createNewTeamLabel);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.newEntryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.newTournamentValue);
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
        private System.Windows.Forms.TextBox newTournamentValue;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.ComboBox newEntryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLabel;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button addPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListBox;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button removeSelectedPlayersButton;
        private System.Windows.Forms.Button removeSelectedPrizesButton;
        private System.Windows.Forms.Button createNewTournamentButton;
        private System.Windows.Forms.CheckBox danCheckBox;
        private System.Windows.Forms.CheckBox ryuCheckBox;
    }
}