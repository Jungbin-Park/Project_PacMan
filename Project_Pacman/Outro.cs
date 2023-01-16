using PacMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Pacman
{
    internal class GameOver
    {
        Intro intro = new Intro();
        public void OutroScene()
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            int result = 0;

            Console.WriteLine("┌----------------------------------------┐");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            Console.WriteLine($"│            Total Score : {result}      │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("└----------------------------------------┘");

            Console.WriteLine("┌----------------------------------------┐");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│           번호를 입력하세요 >>         │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│              1.다시 시작               │");
            Console.WriteLine("│              2.게임 종료               │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("│                                        │");
            Console.WriteLine("└----------------------------------------┘");

            int key = Convert.ToInt32(Console.ReadLine());
            bool select;
            if (key == 1)
            {
                Console.WriteLine("새 게임을 시작합니다");
                Console.Clear();
                intro.PrintScreen();
            }
            else
            {
                Console.WriteLine("게임을 종료합니다");
                select = false;
            }
        }
    }
}
