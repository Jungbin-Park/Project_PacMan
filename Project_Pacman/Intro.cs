using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Pacman;
using Project_PacMan;
using System.Net.Http;

namespace PacMan
{
    class Intro
    {
        public void PrintScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            GameMap.coinnum = 0;
            Player.Score = 0;

            Console.WriteLine();
            Console.WriteLine("    #########          ###            #########            ##        ##              ###          ##          ##");
            Console.WriteLine("    ##       ##       #####          ##        ##         ####      ####            #####         ###         ##");
            Console.WriteLine("    ##       ##      ##   ##        ##          ##       ##   ##  ##   ##          ##   ##        ##  #       ##");
            Console.WriteLine("    ##      ##      ##     ##       ##                  ##      ##      ##        ##     ##       ##   #      ##");
            Console.WriteLine("    ########       ###########      ##                  ##      ##      ##       ###########      ##    ##    ##");
            Console.WriteLine("    ##            ##         ##     ##                  ##              ##      ##         ##     ##      ##  ##");
            Console.WriteLine("    ##           ##           ##     ##        ##       ##              ##     ##           ##    ##         ###");
            Console.WriteLine("    ##          ##             ##      ########         ##              ##    ##             ##   ##          ##");
            Console.WriteLine();


            int i = 1;
            while (i <= 60)
            {
                Console.Write('*');
                Console.Write(' ');
                ++i;
                System.Threading.Thread.Sleep(5);
            }


            Console.WriteLine("\n\n\n\n\n");
            int k = 1;
            while (k <= 1)
            {
                Console.Write("                                         [Press ");
                System.Threading.Thread.Sleep(500);
                Console.Write("Y - start");
                System.Threading.Thread.Sleep(500);
                Console.Write(" / N - End]");
                System.Threading.Thread.Sleep(500);

                ++k;
            }

            Console.WriteLine("\n\n\n\n\n");
            int j = 1;
            while (j <= 60)
            {
                Console.Write('*');
                Console.Write(' ');
                ++j;
                System.Threading.Thread.Sleep(5);
            }

            for (; ; )
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {

                        Console.Clear();
                        Program.GameScene();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        break;
                    }
                }
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
