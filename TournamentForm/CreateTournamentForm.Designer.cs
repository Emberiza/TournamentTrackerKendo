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
            this.label2 = new System.Windows.Forms.Label();
            this.newTournamentNameBox = new System.Windows.Forms.TextBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.newEntryFeeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createNewNameLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelř = new System.Windows.Forms.Label();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.addPrizeButtpn = new System.Windows.Forms.Button();
            tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            prizesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Create Tournament:";
            // 
            // newTournamentNameBox
            // 
            this.newTournamentNameBox.Location = new System.Drawing.Point(19, 117);
            this.newTournamentNameBox.Name = "newTournamentNameBox";
            this.newTournamentNameBox.Size = new System.Drawing.Size(365, 46);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Entry Fee:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(360, 47);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(17, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Name:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(383, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tournament Players:";
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
            // labelř
            // 
            this.labelř.AutoSize = true;
            this.labelř.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelř.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelř.Location = new System.Drawing.Point(383, 356);
            this.labelř.Name = "labelř";
            this.labelř.Size = new System.Drawing.Size(136, 39);
            this.labelř.TabIndex = 17;
            this.labelř.Text = "Prizes:";
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
            this.Controls.Add(this.labelř);
            this.Controls.Add(tournamentPlayersListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createNewNameLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newEntryFeeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newTournamentNameBox);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newTournamentNameBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.ComboBox newEntryFeeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel createNewNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelř;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button addPrizeButtpn;
    }
}