using MyGame.GameMain.Actions.Battle;
using MyGame.GameMain.Living.Monster;
using MyGame.GameMain.Living.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new Form1());

            Player player = new Player("Livew", 20, 20, 3, 5, 0, 1);
        }
    }
}
