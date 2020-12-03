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
            this.travelButton = new System.Windows.Forms.Button();
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.travelButton);
            this.Controls.Add(this.button4);
            this.Location = new System.Drawing.Point(78, 338);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button travelButton;
    }
}

