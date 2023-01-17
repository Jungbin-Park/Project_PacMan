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
        private static void Main(string[] args)
        {
            Intro intro = new Intro();
            Outro outro = new Outro();
            intro.PrintScreen();
            
            //outro.OutroScene();
        }

        static public void GameScene()
        {
            int size = 11;
            GameMap gmap = new GameMap();
            gmap.Initialize(size);
            Console.CursorVisible = false;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                gmap.Render();
            }
        }
       
    }
}
