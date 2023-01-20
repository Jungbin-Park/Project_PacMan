using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Pacman;
using Project_PacMan;

namespace PacMan
{
    class Intro
    {
        public void PrintScreen()
        {
            GameMap.coinnum = 0;
            Player.Score = 0;

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
            int i = 1;
            while (i <= 110)
            {
                Console.Write('*');
                ++i;
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("\n\n\n\n\n");
            int k = 1;
            while (k <= 1)
            {
                Console.Write("                                         [Press ");
                System.Threading.Thread.Sleep(300);
                Console.Write("any key");
                System.Threading.Thread.Sleep(300);
                Console.Write(" to start]");
                System.Threading.Thread.Sleep(300);

                ++k;
            }

            Console.WriteLine("\n\n\n\n\n");
            int j = 1;
            while (j <= 110)
            {
                Console.Write('*');
                ++j;
                System.Threading.Thread.Sleep(10);
            }

            Console.ReadKey();
            Console.Clear();
            Program.GameScene();

        }
    }
}