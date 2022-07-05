namespace TournamentForm
{
    partial class CreatePrizeForm
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
            this.createPrizeLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizeNumberValue = new System.Windows.Forms.TextBox();
            this.prizeNumberLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.prizeNameLabel = new System.Windows.Forms.Label();
            this.prizeNameValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createPrizeLabel
            // 
            this.createPrizeLabel.AutoSize = true;
            this.createPrizeLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createPrizeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createPrizeLabel.Location = new System.Drawing.Point(12, 9);
            this.createPrizeLabel.Name = "createPrizeLabel";
            this.createPrizeLabel.Size = new System.Drawing.Size(238, 39);
            this.createPrizeLabel.TabIndex = 11;
            this.createPrizeLabel.Text = "Create Prize:";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(358, 176);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(156, 30);
            this.prizeAmountValue.TabIndex = 21;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeAmountLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prizeAmountLabel.Location = new System.Drawing.Point(57, 167);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(238, 39);
            this.prizeAmountLabel.TabIndex = 20;
            this.prizeAmountLabel.Text = "Prize Amount:";
            // 
            // prizeNumberValue
            // 
            this.prizeNumberValue.Location = new System.Drawing.Point(358, 128);
            this.prizeNumberValue.Name = "prizeNumberValue";
            this.prizeNumberValue.Size = new System.Drawing.Size(156, 30);
            this.prizeNumberValue.TabIndex = 17;
            // 
            // prizeNumberLabel
            // 
            this.prizeNumberLabel.AutoSize = true;
            this.prizeNumberLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeNumberLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prizeNumberLabel.Location = new System.Drawing.Point(57, 119);
            this.prizeNumberLabel.Name = "prizeNumberLabel";
            this.prizeNumberLabel.Size = new System.Drawing.Size(238, 39);
            this.prizeNumberLabel.TabIndex = 16;
            this.prizeNumberLabel.Text = "Prize Number:";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createPrizeButton.Location = new System.Drawing.Point(191, 258);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(190, 77);
            this.createPrizeButton.TabIndex = 25;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // prizeNameLabel
            // 
            this.prizeNameLabel.AutoSize = true;
            this.prizeNameLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prizeNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prizeNameLabel.Location = new System.Drawing.Point(57, 70);
            this.prizeNameLabel.Name = "prizeNameLabel";
            this.prizeNameLabel.Size = new System.Drawing.Size(204, 39);
            this.prizeNameLabel.TabIndex = 26;
            this.prizeNameLabel.Text = "Prize Name:";
            // 
            // prizeNameValue
            // 
            this.prizeNameValue.Location = new System.Drawing.Point(358, 79);
            this.prizeNameValue.Name = "prizeNameValue";
            this.prizeNameValue.Size = new System.Drawing.Size(156, 30);
            this.prizeNameValue.TabIndex = 27;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(581, 347);
            this.Controls.Add(this.prizeNameValue);
            this.Controls.Add(this.prizeNameLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.prizeNumberValue);
            this.Controls.Add(this.prizeNumberLabel);
            this.Controls.Add(this.createPrizeLabel);
            this.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreatePrizeForm";
            this.Text = "r";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.TextBox prizeNumberValue;
        private System.Windows.Forms.Label prizeNumberLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label prizeNameLabel;
        private System.Windows.Forms.TextBox prizeNameValue;
    }
}