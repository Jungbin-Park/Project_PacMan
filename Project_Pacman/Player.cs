using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Pacman;

namespace Project_Pacman
{
    public class Player
    {
        public void PlayerMove()
        {
            int x = 2;
            int y = 1;
            Console.CursorVisible = false;
            //Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write("○");

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("○");
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if(x > 2)
                        x -= 2;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if(x < 18)
                        x += 2;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        y++;
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }
        }
           

   
    }
}
