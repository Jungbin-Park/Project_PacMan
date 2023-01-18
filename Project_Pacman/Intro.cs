using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Pacman;
using Project_PacMan;

namespace PacMan
{
    internal class Intro
    {
        public void PrintScreen()
        {
            GameMap.coinnum = 0;
            Player.Score= 0;

            Console.WriteLine();
            Console.WriteLine("#########          ###            #########            ##        ##              ###          ##          ##");
            Console.WriteLine("##       ##       #####          ##        ##         ####      ####            #####         ###         ##");
            Console.WriteLine("##       ##      ##   ##        ##          ##       ##   ##  ##   ##          ##   ##        ##  #       ##");
            Console.WriteLine("##      ##      ##     ##       ##                  ##      ##      ##        ##     ##       ##   #      ##");
            Console.WriteLine("########       ###########      ##                  ##      ##      ##       ###########      ##    ##    ##");
            Console.WriteLine("##            ##         ##     ##                  ##              ##      ##         ##     ##      ##  ##");
            Console.WriteLine("##           ##           ##     ##        ##       ##              ##     ##           ##    ##         ###");
            Console.WriteLine("##          ##             ##      ########         ##              ##    ##             ##   ##          ##");


            Console.WriteLine();
            Console.WriteLine("==============================================================================================================");
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.Write("                                           [Press any key to start]");

            Console.ReadKey();
            Console.Clear();
            Program.GameScene();

        }
       
    }
}