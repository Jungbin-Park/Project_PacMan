using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PacMan;
using Project_PacMan;

namespace Project_Pacman
{
    public class Player
    {
        public static bool playerisRun;
        public static int Score = 0;
        private Outro outro = new Outro();
        private GameMap gMap = new GameMap();
        private Intro intro = new Intro();
        
        public void PlayerMove()
        {
            playerisRun = true;   //반복문 초기화
            Score = 0;            //점수 초기화
            int x = 2, y = 1;     //플레이어 초기 위치
            GameMap.result = 0;   //총점수 초기화

            int x1 = 4;
            int y1 = 2;
            int x2 = 16;
            int x3 = 4;
            int x4 = 16;
            int x5 = 4;
            
            Console.CursorVisible = false;
            
            Console.SetCursorPosition(x, y);
            while (playerisRun)
            {
                gMap.GameScorePrint();
                Console.SetCursorPosition(x, y);
                Console.Write("○");

                ConsoleKeyInfo cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if ((int)GameMap._tile[y, (x - 2) / 2] != 1)
                            x -= 2;
                        while (y == 3)
                        {
                            if (x == x2)
                            {
                                Score += 1;
                                x2 -= 2;
                            }
                            break;
                        }

                        while (y == 7)
                        {
                            if (x == x4)
                            {
                                Score += 1;
                                x4 -= 2;
                            }
                            break;
                        }
                        gMap.GameScore();
                        break;
                    case ConsoleKey.RightArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if ((int)GameMap._tile[y, (x + 2) / 2] != 1)
                            x += 2;
                        while (y == 1)
                        {
                            if (x == x1)
                            {
                                Score += 1;
                                x1 += 2;
                            }
                            break;
                        }

                        while (y == 5)
                        {
                            if (x == x3)
                            {
                                Score += 1;
                                x3 += 2;
                            }
                            break;
                        }

                        while (y == 9)
                        {
                            if (x == x5)
                            {
                                Score += 1;
                                x5 += 2;
                            }
                            break;
                        }
                        gMap.GameScore();
                        break;
                    case ConsoleKey.UpArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if ((int)GameMap._tile[y - 1, x / 2] != 1)
                            y -= 1;
                        gMap.GameScore();
                        break;
                    case ConsoleKey.DownArrow:
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("  ");
                        if ((int)GameMap._tile[y + 1, x / 2] != 1)
                            y += 1;
                        while (x == 2 || x == 18)
                        {
                            if (y == y1)
                            {
                                Score += 1;
                                ++y1;
                            }
                            break;
                        }
                        gMap.GameScore();
                        break;
                    case ConsoleKey.Q:
                        Console.Clear();
                        playerisRun = false;
                        outro.OutroScene(intro);
                        break;
                }       
            }
        }
    }
}