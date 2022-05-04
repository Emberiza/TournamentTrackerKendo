namespace TournamentForm
{
    partial class TournamentViewer
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
            System.Windows.Forms.ListBox matchupListBox;
            this.tournamentViewLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.scoreTeamOneLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.scoreTeamTwoLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.tournamentLabel = new System.Windows.Forms.Label();
            matchupListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 25;
            matchupListBox.Location = new System.Drawing.Point(65, 166);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new System.Drawing.Size(415, 352);
            matchupListBox.TabIndex = 4;
            // 
            // tournamentViewLabel
            // 
            this.tournamentViewLabel.AutoSize = true;
            this.tournamentViewLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentViewLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tournamentViewLabel.Location = new System.Drawing.Point(276, 37);
            this.tournamentViewLabel.Name = "tournamentViewLabel";
            this.tournamentViewLabel.Size = new System.Drawing.Size(204, 39);
            this.tournamentViewLabel.TabIndex = 0;
            this.tournamentViewLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tournamentName.Location = new System.Drawing.Point(486, 37);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(187, 39);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<<<none>>>";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teamOneName.Location = new System.Drawing.Point(571, 166);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(255, 39);
            this.teamOneName.TabIndex = 5;
            this.teamOneName.Text = "<<<Team One>>>";
            // 
            // scoreTeamOneLabel
            // 
            this.scoreTeamOneLabel.AutoSize = true;
            this.scoreTeamOneLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreTeamOneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreTeamOneLabel.Location = new System.Drawing.Point(486, 217);
            this.scoreTeamOneLabel.Name = "scoreTeamOneLabel";
            this.scoreTeamOneLabel.Size = new System.Drawing.Size(119, 39);
            this.scoreTeamOneLabel.TabIndex = 6;
            this.scoreTeamOneLabel.Text = "Score:";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(602, 225);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(303, 30);
            this.teamOneScoreValue.TabIndex = 7;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(602, 344);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(303, 30);
            this.teamTwoScoreValue.TabIndex = 10;
            // 
            // scoreTeamTwoLabel
            // 
            this.scoreTeamTwoLabel.AutoSize = true;
            this.scoreTeamTwoLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreTeamTwoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreTeamTwoLabel.Location = new System.Drawing.Point(486, 336);
            this.scoreTeamTwoLabel.Name = "scoreTeamTwoLabel";
            this.scoreTeamTwoLabel.Size = new System.Drawing.Size(119, 39);
            this.scoreTeamTwoLabel.TabIndex = 9;
            this.scoreTeamTwoLabel.Text = "Score:";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teamTwoName.Location = new System.Drawing.Point(571, 285);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(255, 39);
            this.teamTwoName.TabIndex = 8;
            this.teamTwoName.Text = "<<<Team Two>>>";
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.scoreButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreButton.Location = new System.Drawing.Point(649, 414);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(120, 51);
            this.scoreButton.TabIndex = 11;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tournamentLabel.Location = new System.Drawing.Point(58, 123);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(204, 39);
            this.tournamentLabel.TabIndex = 2;
            this.tournamentLabel.Text = "Tournament:";
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(934, 650);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.scoreTeamTwoLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.scoreTeamOneLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(matchupListBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tournamentLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.tournamentViewLabel);
            this.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentViewLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label scoreTeamOneLabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label scoreTeamTwoLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Label tournamentLabel;
    }
}

