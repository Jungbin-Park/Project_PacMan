using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using PacMan;
using Project_PacMan;

namespace Project_Pacman
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Intro intro = new Intro();
            GameOver outro = new GameOver();
            intro.PrintScreen();
            
            //outro.OutroScene();
            
        }

        static public void GameScene()
        {
            GameMap gmap = new GameMap();
            gmap.Initialize(11);

            Console.CursorVisible = false;

            const int WAIT_TICK = 1000 / 30;

            int lastTick = 0;

            while (true)
            {
                #region
                int currentTick = System.Environment.TickCount;
                int elapsedTick = currentTick - lastTick;

                if (elapsedTick < 1000 / 30)
                    continue;
                lastTick = currentTick;
                #endregion

                Console.SetCursorPosition(0, 0);
                gmap.Render();
            }
        }
        /*
        public int PosY { get; private set; }
        public int PosX { get; private set; }
        Random _random = new Random();
        GameMap _board;

        public void Intiallize(int posY, int posX, GameMap board) // 초기 위치설정
        {
            PosX = posX;
            PosY = posY;
            _board = board;
        }

        const int MOVE_TICK = 10; // 0.1초
        int _sumTick = 0;
        int _lastIndex = 0;
        public void Update(int deltaTick)
        {
            if (_lastIndex >= _points.Count)
            {
                return;
            }

            _sumTick += deltaTick;
            if (_sumTick >= MOVE_TICK)
            {
                _sumTick = 0;

                // 여기에다가 0.1초마다 실행될 로직을 넣어준다.
                PosY = _points[_lastIndex].Y;
                PosX = _points[_lastIndex].X;
                _lastIndex++;
            }

        }
        */
    }
}
