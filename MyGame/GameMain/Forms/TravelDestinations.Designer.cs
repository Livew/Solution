namespace MyGame.GameMain.Forms
{
    partial class TravelDestinations
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
            this.backToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMain
            // 
            this.backToMain.Location = new System.Drawing.Point(442, 336);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(75, 23);
            this.backToMain.TabIndex = 5;
            this.backToMain.Text = "Back";
            this.backToMain.UseVisualStyleBackColor = true;
            this.backToMain.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // TravelDestinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToMain);
            this.Name = "TravelDestinations";
            this.Text = "TravelDestinations";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backToMain;
    }
}