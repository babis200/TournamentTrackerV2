
namespace TrackerUI
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
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.TeamNameBox = new System.Windows.Forms.TextBox();
            this.SelectMemberLabel = new System.Windows.Forms.Label();
            this.SelectMemberCombo = new System.Windows.Forms.ComboBox();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CellphoneText = new System.Windows.Forms.TextBox();
            this.CreateNewMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroup = new System.Windows.Forms.GroupBox();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTeamLabel.Location = new System.Drawing.Point(68, 38);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(209, 40);
            this.CreateTeamLabel.TabIndex = 0;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.Location = new System.Drawing.Point(45, 89);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(118, 22);
            this.TeamNameLabel.TabIndex = 1;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // TeamNameBox
            // 
            this.TeamNameBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeamNameBox.Location = new System.Drawing.Point(48, 119);
            this.TeamNameBox.Name = "TeamNameBox";
            this.TeamNameBox.Size = new System.Drawing.Size(242, 29);
            this.TeamNameBox.TabIndex = 3;
            // 
            // SelectMemberLabel
            // 
            this.SelectMemberLabel.AutoSize = true;
            this.SelectMemberLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectMemberLabel.Location = new System.Drawing.Point(45, 172);
            this.SelectMemberLabel.Name = "SelectMemberLabel";
            this.SelectMemberLabel.Size = new System.Drawing.Size(204, 22);
            this.SelectMemberLabel.TabIndex = 4;
            this.SelectMemberLabel.Text = "Select Team Member";
            // 
            // SelectMemberCombo
            // 
            this.SelectMemberCombo.FormattingEnabled = true;
            this.SelectMemberCombo.Location = new System.Drawing.Point(45, 197);
            this.SelectMemberCombo.Name = "SelectMemberCombo";
            this.SelectMemberCombo.Size = new System.Drawing.Size(246, 27);
            this.SelectMemberCombo.TabIndex = 5;
            this.SelectMemberCombo.SelectedIndexChanged += new System.EventHandler(this.SelectMemberCombo_SelectedIndexChanged);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Location = new System.Drawing.Point(80, 246);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(142, 32);
            this.AddMemberButton.TabIndex = 6;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 19;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(337, 89);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(270, 346);
            this.TournamentPlayersListBox.TabIndex = 7;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(16, 57);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(91, 19);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.Location = new System.Drawing.Point(14, 98);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(90, 19);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Last Name";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(17, 134);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 19);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Email";
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CellphoneLabel.Location = new System.Drawing.Point(17, 168);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(87, 19);
            this.CellphoneLabel.TabIndex = 12;
            this.CellphoneLabel.Text = "Cellphone";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameTextBox.Location = new System.Drawing.Point(132, 91);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(123, 26);
            this.LastNameTextBox.TabIndex = 14;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameTextBox.Location = new System.Drawing.Point(132, 50);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(123, 26);
            this.FirstNameTextBox.TabIndex = 15;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTextBox.Location = new System.Drawing.Point(132, 127);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(123, 26);
            this.EmailTextBox.TabIndex = 16;
            // 
            // CellphoneText
            // 
            this.CellphoneText.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellphoneText.Location = new System.Drawing.Point(132, 161);
            this.CellphoneText.Name = "CellphoneText";
            this.CellphoneText.Size = new System.Drawing.Size(123, 26);
            this.CellphoneText.TabIndex = 17;
            // 
            // CreateNewMemberButton
            // 
            this.CreateNewMemberButton.Location = new System.Drawing.Point(54, 202);
            this.CreateNewMemberButton.Name = "CreateNewMemberButton";
            this.CreateNewMemberButton.Size = new System.Drawing.Size(142, 32);
            this.CreateNewMemberButton.TabIndex = 18;
            this.CreateNewMemberButton.Text = "Create Member";
            this.CreateNewMemberButton.UseVisualStyleBackColor = true;
            this.CreateNewMemberButton.Click += new System.EventHandler(this.CreateNewMemberButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Location = new System.Drawing.Point(413, 483);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(142, 32);
            this.CreateTeamButton.TabIndex = 19;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // AddNewMemberGroup
            // 
            this.AddNewMemberGroup.Controls.Add(this.LastNameLabel);
            this.AddNewMemberGroup.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroup.Controls.Add(this.FirstNameTextBox);
            this.AddNewMemberGroup.Controls.Add(this.EmailLabel);
            this.AddNewMemberGroup.Controls.Add(this.EmailTextBox);
            this.AddNewMemberGroup.Controls.Add(this.LastNameTextBox);
            this.AddNewMemberGroup.Controls.Add(this.CreateNewMemberButton);
            this.AddNewMemberGroup.Controls.Add(this.CellphoneText);
            this.AddNewMemberGroup.Controls.Add(this.CellphoneLabel);
            this.AddNewMemberGroup.Location = new System.Drawing.Point(48, 294);
            this.AddNewMemberGroup.Name = "AddNewMemberGroup";
            this.AddNewMemberGroup.Size = new System.Drawing.Size(270, 258);
            this.AddNewMemberGroup.TabIndex = 20;
            this.AddNewMemberGroup.TabStop = false;
            this.AddNewMemberGroup.Text = "Add New Member";
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(623, 223);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(142, 78);
            this.RemoveSelectedButton.TabIndex = 21;
            this.RemoveSelectedButton.Text = "Remove Selected";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(812, 597);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.AddNewMemberGroup);
            this.Controls.Add(this.SelectMemberCombo);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectMemberLabel);
            this.Controls.Add(this.TeamNameBox);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CreateTeamForm";
            this.Text = "Team Creator";
            this.AddNewMemberGroup.ResumeLayout(false);
            this.AddNewMemberGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.TextBox TeamNameBox;
        private System.Windows.Forms.Label SelectMemberLabel;
        private System.Windows.Forms.ComboBox SelectMemberCombo;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox CellphoneText;
        private System.Windows.Forms.Button CreateNewMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.GroupBox AddNewMemberGroup;
        private System.Windows.Forms.Button RemoveSelectedButton;
    }
}