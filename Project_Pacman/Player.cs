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
                        if (x > 2)
                        {
                            if (y == 2 && x == 18)
                            {
                                break;
                            }
                            else if (y == 4 && x == 2)
                            {
                                break;
                            }
                            else if (y == 6 && x == 18)
                            {
                                break;
                            }
                            else if (y == 8 && x == 2)
                            {
                                break;
                            }
                            x -= 2;
                        }

                        break;
                    case ConsoleKey.RightArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if (x < 18)
                        {
                            if (y == 2 && x == 18)
                            {
                                break;
                            }
                            else if (y == 4 && x == 2)
                            {
                                break;
                            }
                            else if (y == 6 && x == 18)
                            {
                                break;
                            }
                            else if (y == 8 && x == 2)
                            {
                                break;
                            }
                            x += 2;
                        }

                        break;
                    case ConsoleKey.UpArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if (y == 1)
                        {
                            break;
                        }
                        if (y == 3)
                        {
                            if (x > 1 && x < 17)
                                break;
                        }
                        if (y == 5)
                        {
                            if (x > 2 && x < 19)
                                break;
                        }
                        if (y == 7)
                        {
                            if (x > 1 && x < 17)
                                break;
                        }
                        if (y == 9)
                        {
                            if (x > 2 && x < 19)
                            {
                                break;
                            }
                        }
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if (y == 9)
                        {
                            break;
                        }
                        if (y == 1)
                        {
                            if (x > 1 && x < 17)
                                break;
                        }
                        if (y == 3)
                        {
                            if (x > 2 && x < 19)
                                break;
                        }
                        if (y == 5)
                        {
                            if (x > 1 && x < 17)
                                break;
                        }
                        if (y == 7)
                        {
                            if (x > 2 && x < 19)
                                break;
                        }
                        y++;
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }
        }
           

   
    }
}
