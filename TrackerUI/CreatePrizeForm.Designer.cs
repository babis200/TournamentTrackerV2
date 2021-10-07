
namespace TrackerUI
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
            this.CreatePrizeLabel = new System.Windows.Forms.Label();
            this.PlaceNumberLabel = new System.Windows.Forms.Label();
            this.PlaceNameLabel = new System.Windows.Forms.Label();
            this.PrizeAmountLabel = new System.Windows.Forms.Label();
            this.PrizePercentageLabel = new System.Windows.Forms.Label();
            this.OrLabel = new System.Windows.Forms.Label();
            this.PlaceNumberText = new System.Windows.Forms.TextBox();
            this.PlaceNameText = new System.Windows.Forms.TextBox();
            this.PrizeAmountText = new System.Windows.Forms.TextBox();
            this.PrizePercentageText = new System.Windows.Forms.TextBox();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            this.CreatePrizeLabel.AutoSize = true;
            this.CreatePrizeLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeLabel.Location = new System.Drawing.Point(42, 35);
            this.CreatePrizeLabel.Name = "CreatePrizeLabel";
            this.CreatePrizeLabel.Size = new System.Drawing.Size(219, 42);
            this.CreatePrizeLabel.TabIndex = 1;
            this.CreatePrizeLabel.Text = "Create Prize";
            // 
            // PlaceNumberLabel
            // 
            this.PlaceNumberLabel.AutoSize = true;
            this.PlaceNumberLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlaceNumberLabel.Location = new System.Drawing.Point(68, 125);
            this.PlaceNumberLabel.Name = "PlaceNumberLabel";
            this.PlaceNumberLabel.Size = new System.Drawing.Size(199, 32);
            this.PlaceNumberLabel.TabIndex = 14;
            this.PlaceNumberLabel.Text = "Place Number";
            this.PlaceNumberLabel.Click += new System.EventHandler(this.PlaceNumberLabel_Click);
            // 
            // PlaceNameLabel
            // 
            this.PlaceNameLabel.AutoSize = true;
            this.PlaceNameLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlaceNameLabel.Location = new System.Drawing.Point(68, 185);
            this.PlaceNameLabel.Name = "PlaceNameLabel";
            this.PlaceNameLabel.Size = new System.Drawing.Size(169, 32);
            this.PlaceNameLabel.TabIndex = 15;
            this.PlaceNameLabel.Text = "Place Name";
            // 
            // PrizeAmountLabel
            // 
            this.PrizeAmountLabel.AutoSize = true;
            this.PrizeAmountLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrizeAmountLabel.Location = new System.Drawing.Point(68, 249);
            this.PrizeAmountLabel.Name = "PrizeAmountLabel";
            this.PrizeAmountLabel.Size = new System.Drawing.Size(192, 32);
            this.PrizeAmountLabel.TabIndex = 16;
            this.PrizeAmountLabel.Text = "Prize Amount";
            // 
            // PrizePercentageLabel
            // 
            this.PrizePercentageLabel.AutoSize = true;
            this.PrizePercentageLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrizePercentageLabel.Location = new System.Drawing.Point(68, 391);
            this.PrizePercentageLabel.Name = "PrizePercentageLabel";
            this.PrizePercentageLabel.Size = new System.Drawing.Size(235, 32);
            this.PrizePercentageLabel.TabIndex = 17;
            this.PrizePercentageLabel.Text = "Prize Percentage";
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrLabel.Location = new System.Drawing.Point(285, 316);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(73, 32);
            this.OrLabel.TabIndex = 18;
            this.OrLabel.Text = "-OR-";
            // 
            // PlaceNumberText
            // 
            this.PlaceNumberText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNumberText.Location = new System.Drawing.Point(387, 125);
            this.PlaceNumberText.Name = "PlaceNumberText";
            this.PlaceNumberText.Size = new System.Drawing.Size(229, 29);
            this.PlaceNumberText.TabIndex = 19;
            // 
            // PlaceNameText
            // 
            this.PlaceNameText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceNameText.Location = new System.Drawing.Point(387, 187);
            this.PlaceNameText.Name = "PlaceNameText";
            this.PlaceNameText.Size = new System.Drawing.Size(229, 29);
            this.PlaceNameText.TabIndex = 20;
            // 
            // PrizeAmountText
            // 
            this.PrizeAmountText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizeAmountText.Location = new System.Drawing.Point(387, 249);
            this.PrizeAmountText.Name = "PrizeAmountText";
            this.PrizeAmountText.Size = new System.Drawing.Size(229, 29);
            this.PrizeAmountText.TabIndex = 21;
            this.PrizeAmountText.Text = "0";
            this.PrizeAmountText.TextChanged += new System.EventHandler(this.PrizeAmountText_TextChanged);
            // 
            // PrizePercentageText
            // 
            this.PrizePercentageText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrizePercentageText.Location = new System.Drawing.Point(387, 394);
            this.PrizePercentageText.Name = "PrizePercentageText";
            this.PrizePercentageText.Size = new System.Drawing.Size(229, 29);
            this.PrizePercentageText.TabIndex = 22;
            this.PrizePercentageText.Text = "0";
            this.PrizePercentageText.TextChanged += new System.EventHandler(this.PrizePercentageText_TextChanged);
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatePrizeButton.Location = new System.Drawing.Point(223, 451);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(219, 64);
            this.CreatePrizeButton.TabIndex = 23;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(690, 536);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.PrizePercentageText);
            this.Controls.Add(this.PrizeAmountText);
            this.Controls.Add(this.PlaceNameText);
            this.Controls.Add(this.PlaceNumberText);
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.PrizePercentageLabel);
            this.Controls.Add(this.PrizeAmountLabel);
            this.Controls.Add(this.PlaceNameLabel);
            this.Controls.Add(this.PlaceNumberLabel);
            this.Controls.Add(this.CreatePrizeLabel);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreatePrizeForm";
            this.Text = "Prize Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreatePrizeLabel;
        private System.Windows.Forms.Label PlaceNumberLabel;
        private System.Windows.Forms.Label PlaceNameLabel;
        private System.Windows.Forms.Label PrizeAmountLabel;
        private System.Windows.Forms.Label PrizePercentageLabel;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.TextBox PlaceNumberText;
        private System.Windows.Forms.TextBox PlaceNameText;
        private System.Windows.Forms.TextBox PrizeAmountText;
        private System.Windows.Forms.TextBox PrizePercentageText;
        private System.Windows.Forms.Button CreatePrizeButton;
    }
}