using MyGame.GameMain.Actions.Battle;
using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using MyGame.GameMain.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGame.GameMain.Forms.Move;

namespace MyGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu());

            Application.Run(new TestMove());
            Player player = new Player("Livew", 20, 20, 0, 1, 1, new List<Item>());
        }
    }
}
