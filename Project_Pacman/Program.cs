using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Project_Pacman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true;
            ConsoleKeyInfo cki;
            int x = 40, y = 20;

            while (isRun)
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write('*');
                cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.Q:
                        return;

                }

                Console.WriteLine("hi");
            }
        }
    }
}
