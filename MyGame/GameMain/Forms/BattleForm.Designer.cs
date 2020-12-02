namespace MyGame.GameMain.Forms
{
    partial class BattleForm
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
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.monsterNameLabel = new System.Windows.Forms.Label();
            this.playerHpLabel = new System.Windows.Forms.Label();
            this.monsterHpLabel = new System.Windows.Forms.Label();
            this.backToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(100, 66);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(35, 13);
            this.playerNameLabel.TabIndex = 0;
            this.playerNameLabel.Text = "label1";
            // 
            // monsterNameLabel
            // 
            this.monsterNameLabel.AutoSize = true;
            this.monsterNameLabel.Location = new System.Drawing.Point(358, 66);
            this.monsterNameLabel.Name = "monsterNameLabel";
            this.monsterNameLabel.Size = new System.Drawing.Size(35, 13);
            this.monsterNameLabel.TabIndex = 1;
            this.monsterNameLabel.Text = "label2";
            // 
            // playerHpLabel
            // 
            this.playerHpLabel.AutoSize = true;
            this.playerHpLabel.Location = new System.Drawing.Point(100, 113);
            this.playerHpLabel.Name = "playerHpLabel";
            this.playerHpLabel.Size = new System.Drawing.Size(35, 13);
            this.playerHpLabel.TabIndex = 2;
            this.playerHpLabel.Text = "label3";
            // 
            // monsterHpLabel
            // 
            this.monsterHpLabel.AutoSize = true;
            this.monsterHpLabel.Location = new System.Drawing.Point(358, 113);
            this.monsterHpLabel.Name = "monsterHpLabel";
            this.monsterHpLabel.Size = new System.Drawing.Size(35, 13);
            this.monsterHpLabel.TabIndex = 3;
            this.monsterHpLabel.Text = "label4";
            // 
            // backToMain
            // 
            this.backToMain.Location = new System.Drawing.Point(103, 195);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(75, 23);
            this.backToMain.TabIndex = 4;
            this.backToMain.Text = "Back";
            this.backToMain.UseVisualStyleBackColor = true;
            this.backToMain.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.backToMain);
            this.Controls.Add(this.monsterHpLabel);
            this.Controls.Add(this.playerHpLabel);
            this.Controls.Add(this.monsterNameLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Location = new System.Drawing.Point(78, 338);
            this.Name = "BattleForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label monsterNameLabel;
        private System.Windows.Forms.Label playerHpLabel;
        private System.Windows.Forms.Label monsterHpLabel;
        private System.Windows.Forms.Button backToMain;
    }
}