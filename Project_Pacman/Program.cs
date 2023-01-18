using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using PacMan;
using Project_PacMan;

namespace Project_Pacman
{
    internal class Program
    {
        static public bool gameisRun;
        private static void Main(string[] args)
        {
            Intro intro = new Intro();
            Outro outro = new Outro();
            intro.PrintScreen();
        }

        static public void GameScene()
        {
            gameisRun = true;
            GameMap gmap = new GameMap();
            int size = 11;
            gmap.Initialize(size);
            Console.CursorVisible = false;

            while (gameisRun)
            {
                Console.SetCursorPosition(0, 0);
                gmap.Render();
            }
        }

    }
}