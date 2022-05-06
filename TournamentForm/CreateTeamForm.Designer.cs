﻿namespace TournamentForm
{
    partial class CreateTeamForm
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
            this.newTeamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.rankDropDown = new System.Windows.Forms.ComboBox();
            this.rankLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.ageValue = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.mailValue = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newTeamNameValue
            // 
            this.newTeamNameValue.Location = new System.Drawing.Point(19, 117);
            this.newTeamNameValue.Name = "newTeamNameValue";
            this.newTeamNameValue.Size = new System.Drawing.Size(365, 30);
            this.newTeamNameValue.TabIndex = 12;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teamNameLabel.Location = new System.Drawing.Point(12, 75);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(187, 39);
            this.teamNameLabel.TabIndex = 11;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTeamLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(221, 39);
            this.createTeamLabel.TabIndex = 10;
            this.createTeamLabel.Text = "Create Team:";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addMemberButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addMemberButton.Location = new System.Drawing.Point(115, 276);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(186, 51);
            this.addMemberButton.TabIndex = 22;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(24, 203);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(360, 33);
            this.selectTeamMemberDropDown.TabIndex = 21;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(17, 161);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(340, 39);
            this.selectTeamMemberLabel.TabIndex = 20;
            this.selectTeamMemberLabel.Text = "Select Team Member:";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.rankDropDown);
            this.addNewMemberGroupBox.Controls.Add(this.rankLabel);
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.ageValue);
            this.addNewMemberGroupBox.Controls.Add(this.ageLabel);
            this.addNewMemberGroupBox.Controls.Add(this.mailValue);
            this.addNewMemberGroupBox.Controls.Add(this.mailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(19, 363);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(365, 288);
            this.addNewMemberGroupBox.TabIndex = 23;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            // 
            // rankDropDown
            // 
            this.rankDropDown.FormattingEnabled = true;
            this.rankDropDown.Items.AddRange(new object[] {
            "1st Kyu",
            "10th Kyu",
            "1st Dan",
            "10th Dan"});
            this.rankDropDown.Location = new System.Drawing.Point(201, 197);
            this.rankDropDown.Name = "rankDropDown";
            this.rankDropDown.Size = new System.Drawing.Size(156, 33);
            this.rankDropDown.TabIndex = 24;
            // 
            // rankLabel
            // 
            this.rankLabel.AutoSize = true;
            this.rankLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rankLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rankLabel.Location = new System.Drawing.Point(10, 189);
            this.rankLabel.Name = "rankLabel";
            this.rankLabel.Size = new System.Drawing.Size(102, 39);
            this.rankLabel.TabIndex = 17;
            this.rankLabel.Text = "Rank:";
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createMemberButton.Location = new System.Drawing.Point(96, 231);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(164, 51);
            this.createMemberButton.TabIndex = 16;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = false;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // ageValue
            // 
            this.ageValue.Location = new System.Drawing.Point(201, 156);
            this.ageValue.Name = "ageValue";
            this.ageValue.Size = new System.Drawing.Size(156, 30);
            this.ageValue.TabIndex = 15;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ageLabel.Location = new System.Drawing.Point(10, 148);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(85, 39);
            this.ageLabel.TabIndex = 14;
            this.ageLabel.Text = "Age:";
            // 
            // mailValue
            // 
            this.mailValue.Location = new System.Drawing.Point(201, 114);
            this.mailValue.Name = "mailValue";
            this.mailValue.Size = new System.Drawing.Size(156, 30);
            this.mailValue.TabIndex = 13;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mailLabel.Location = new System.Drawing.Point(10, 106);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(119, 39);
            this.mailLabel.TabIndex = 12;
            this.mailLabel.Text = "Email:";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(203, 73);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(156, 30);
            this.lastNameValue.TabIndex = 11;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastNameLabel.Location = new System.Drawing.Point(10, 67);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(187, 39);
            this.lastNameLabel.TabIndex = 10;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(203, 34);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(156, 30);
            this.firstNameValue.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 26);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(204, 39);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "First Name:";
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(882, 276);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(117, 73);
            this.deleteSelectedMemberButton.TabIndex = 17;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = false;
            this.deleteSelectedMemberButton.Click += new System.EventHandler(this.deleteSelectedMemberButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createTeamButton.Location = new System.Drawing.Point(390, 649);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(190, 77);
            this.createTeamButton.TabIndex = 17;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 25;
            this.teamMembersListBox.Location = new System.Drawing.Point(390, 117);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(486, 529);
            this.teamMembersListBox.TabIndex = 24;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1028, 738);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.newTeamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newTeamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.TextBox ageValue;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox mailValue;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Label rankLabel;
        private System.Windows.Forms.ComboBox rankDropDown;
        private System.Windows.Forms.ListBox teamMembersListBox;
    }
}