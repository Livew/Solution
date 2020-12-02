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

namespace MyGame.GameMain.Forms
{
    public partial class Form2 : Form
    {
        public Form2(Player player, Monster monster)
        {
            InitializeComponent();

            label1.Text = player.name;
            label2.Text = monster.name;
        }
    }
}
