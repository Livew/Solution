namespace MyGame
{
    partial class MainMenu
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
            this.button4 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerLevelLabel = new System.Windows.Forms.Label();
            this.playerInventoryList = new System.Windows.Forms.ListBox();
            this.travelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerLocationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(357, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Eat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(43, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "PlayerName: ";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(43, 42);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(39, 13);
            this.levelLabel.TabIndex = 8;
            this.levelLabel.Text = "Level: ";
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(119, 20);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.playerNameLabel.TabIndex = 9;
            this.playerNameLabel.Text = "Livew";
            // 
            // playerLevelLabel
            // 
            this.playerLevelLabel.AutoSize = true;
            this.playerLevelLabel.Location = new System.Drawing.Point(119, 42);
            this.playerLevelLabel.Name = "playerLevelLabel";
            this.playerLevelLabel.Size = new System.Drawing.Size(13, 13);
            this.playerLevelLabel.TabIndex = 10;
            this.playerLevelLabel.Text = "1";
            // 
            // playerInventoryList
            // 
            this.playerInventoryList.FormattingEnabled = true;
            this.playerInventoryList.Location = new System.Drawing.Point(205, 20);
            this.playerInventoryList.Name = "playerInventoryList";
            this.playerInventoryList.Size = new System.Drawing.Size(120, 95);
            this.playerInventoryList.TabIndex = 11;
            this.playerInventoryList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // travelButton
            // 
            this.travelButton.Location = new System.Drawing.Point(46, 199);
            this.travelButton.Name = "travelButton";
            this.travelButton.Size = new System.Drawing.Size(88, 30);
            this.travelButton.TabIndex = 12;
            this.travelButton.Text = "Travel";
            this.travelButton.UseVisualStyleBackColor = true;
            this.travelButton.Click += new System.EventHandler(this.travelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Location: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // playerLocationLabel
            // 
            this.playerLocationLabel.AutoSize = true;
            this.playerLocationLabel.Location = new System.Drawing.Point(122, 66);
            this.playerLocationLabel.Name = "playerLocationLabel";
            this.playerLocationLabel.Size = new System.Drawing.Size(48, 13);
            this.playerLocationLabel.TabIndex = 14;
            this.playerLocationLabel.Text = "Location";
            this.playerLocationLabel.Click += new System.EventHandler(this.playerLocationLabel_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.playerLocationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.travelButton);
            this.Controls.Add(this.playerInventoryList);
            this.Controls.Add(this.playerLevelLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button4);
            this.Location = new System.Drawing.Point(78, 338);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label playerLevelLabel;
        public System.Windows.Forms.ListBox playerInventoryList;
        private System.Windows.Forms.Button travelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerLocationLabel;
    }
}

