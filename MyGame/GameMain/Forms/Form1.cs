using MyGame.GameMain.Actions.Battle;
using MyGame.GameMain.Forms;
using MyGame.GameMain.Items.Food;
using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 formBattle = new Form2();
            formBattle.Show();

            Rat rat = new Rat();

            Battle battle = new Battle(Player.getPlayer(), rat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BigRat bigRat = new BigRat();

            Battle battle = new Battle(Player.getPlayer(), bigRat);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player player = Player.getPlayer();
            Cheese cheese = new Cheese();

            player.eat(cheese);
        }
    }
}
