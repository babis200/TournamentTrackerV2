
namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.LoadExistingLabel = new System.Windows.Forms.Label();
            this.LoadExistingCombo = new System.Windows.Forms.ComboBox();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DashboardLabel.Location = new System.Drawing.Point(40, 35);
            this.DashboardLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.Size = new System.Drawing.Size(405, 42);
            this.DashboardLabel.TabIndex = 1;
            this.DashboardLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingLabel
            // 
            this.LoadExistingLabel.AutoSize = true;
            this.LoadExistingLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingLabel.Location = new System.Drawing.Point(63, 122);
            this.LoadExistingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoadExistingLabel.Name = "LoadExistingLabel";
            this.LoadExistingLabel.Size = new System.Drawing.Size(363, 32);
            this.LoadExistingLabel.TabIndex = 14;
            this.LoadExistingLabel.Text = "Load Existing Tournament";
            // 
            // LoadExistingCombo
            // 
            this.LoadExistingCombo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadExistingCombo.FormattingEnabled = true;
            this.LoadExistingCombo.Location = new System.Drawing.Point(85, 198);
            this.LoadExistingCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadExistingCombo.Name = "LoadExistingCombo";
            this.LoadExistingCombo.Size = new System.Drawing.Size(380, 30);
            this.LoadExistingCombo.TabIndex = 15;
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadTournamentButton.Location = new System.Drawing.Point(138, 272);
            this.LoadTournamentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(275, 44);
            this.LoadTournamentButton.TabIndex = 16;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            this.LoadTournamentButton.Click += new System.EventHandler(this.LoadTournamentButton_Click);
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateTournamentButton.Location = new System.Drawing.Point(79, 355);
            this.CreateTournamentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(392, 103);
            this.CreateTournamentButton.TabIndex = 17;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(559, 489);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingCombo);
            this.Controls.Add(this.LoadExistingLabel);
            this.Controls.Add(this.DashboardLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TournamentDashboardForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Label LoadExistingLabel;
        private System.Windows.Forms.ComboBox LoadExistingCombo;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}