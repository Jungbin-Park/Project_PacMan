using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Pacman;
using Project_PacMan;

namespace Project_Pacman
{
    public class Player
    {
        static int x = 2, y = 1;
        public void PlayerMove()
        {
            GameOver outro = new GameOver();
            GameMap gMap= new GameMap();
            
            
            Console.CursorVisible = false;
            //Console.Clear();
            Console.SetCursorPosition(x, y);
            //Console.Write("○");

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("○");
                /*
                for(int i = 0; i < 11; i++)
                {
                    Console.Write((int)GameMap._tile[2, i]);
                }
                */
                
                ConsoleKeyInfo cki = Console.ReadKey(true);

                
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if ((int)GameMap._tile[y, (x - 2) / 2] != 1)
                            x -= 2;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if ((int)GameMap._tile[y, (x + 2) / 2] != 1)
                            x += 2;
                        break;
                    case ConsoleKey.UpArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if ((int)GameMap._tile[y - 1, x / 2] != 1)
                            y -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if ((int)GameMap._tile[y + 1, x / 2] != 1)
                            y += 1;
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        outro.OutroScene();
                        return;
                }
            }
        }
           

   
    }
}
