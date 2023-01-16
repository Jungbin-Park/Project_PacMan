using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Pacman;

namespace PacMan
{
    internal class Intro
    {
        public void PrintScreen()
        {
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
            ConsoleKeyInfo keys;
            keys = Console.ReadKey();
            if(keys != null)
            {
                Console.Clear();
                Program.GameScene();
                
            }

            

        }
       
    }
}