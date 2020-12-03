using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame.GameMain.Forms.Move
{
    public partial class TestMove : Form
    {
        Label labelPlayer;
        Button buttonRight;
        Button buttonLeft;
        Button buttonTop;
        Button buttonBottom;
        PictureBox player;
        PictureBox rat1;
        PictureBox rat2;
        PictureBox rat3;

        string playerImage = @"C:\Users\andre.magalhaes\Desktop\Fabi\player.png";
        string ratImage = @"C:\Users\andre.magalhaes\Desktop\Fabi\rat.jfif";

        public TestMove()
        {
            this.KeyDown += new KeyEventHandler(this.TestMove_KeyDown);

            Image myimage = new Bitmap(@"C:\Users\andre.magalhaes\Desktop\Fabi\Sewer-battle-map-by-Asen-Stoyanov-Map-1.jpg");
            this.BackgroundImage = myimage;

            player = generateCreature(playerImage, 50, 100);
            rat1 = generateCreature(ratImage, 150, 300);
            rat2 = generateCreature(ratImage, 250, 500);
            rat3 = generateCreature(ratImage, 350, 800);


            this.Height = 530;
            this.Width = 1010;

            this.Controls.Add(player);
            this.Controls.Add(rat1);
            this.Controls.Add(rat2);
            this.Controls.Add(rat3);

        }

        void moveRight()
        {
            player.Left += 20;
        }

        void moveLeft()
        {
            player.Left -= 20;
        }
        
        void moveTop()
        {
            player.Top -= 20;
        }

        void moveBottom()
        {
            player.Top += 20;
        }

        Button buildButton(string buttonText, int buttonTop, int buttonLeft, Action action)
        {
            Button button = new Button();
            button.Text = buttonText;
            button.Top = buttonTop;
            button.Left = buttonLeft;
            button.Width = 80;
            button.BackColor = Color.Transparent;

            button.Click += (object sender, EventArgs e) => action();

            return button;
        }

        PictureBox generateCreature(string creatureImage, int creatureTop, int creatureLeft)
        {
            PictureBox creature = new PictureBox();
            creature.ImageLocation = creatureImage;
            creature.Top = creatureTop;
            creature.Left = creatureLeft;
            creature.BackColor = Color.Transparent;
            creature.Height = 80;

            return creature;
        }

        private void TestMove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                moveBottom();
            }

            if (e.KeyCode == Keys.Up)
            {
                moveTop();
            }

            if (e.KeyCode == Keys.Left)
            {
                moveLeft();
            }

            if (e.KeyCode == Keys.Right)
            {
                moveRight();
            }
        }
    }
}
