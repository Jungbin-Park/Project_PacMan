using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan;
using Project_Pacman;


namespace Project_PacMan
{
    public class GameMap
    {
        private Outro outro = new Outro();
        private Intro intro = new Intro();

        const char SQUARE = '■';  //벽
        const char COIN = '*';     //코인
        

        static public TileType[,] _tile; //배열
        public int _size;

        public static int result;         //총점
        public static int coinnum = 0;    //코인 개수('*'개수)
        

        // empty, wall 구분 
        public enum TileType
        {
            Empty, // 0
            Wall,  // 1
        }

        public void Initialize(int size)
        {
            _tile = new TileType[size, size];
            _size = size;

            // y축 벽 생성
            for (int y = 0; y < _size; y++)
            {
                // x축 벽 생성
                for (int x = 0; x < _size; x++)
                {
                    // 가장자리
                    if (x == 0 || x == _size - 1 || y == 0 || y == _size - 1)
                    {
                        _tile[y, x] = TileType.Wall;

                    }
                    // 짝수번째에 와리가리 벽
                    else if (y % 2 == 0)
                    {
                        if (y % 4 == 0 && x < _size - 1)
                        {
                            _tile[y, x + 1] = TileType.Wall;

                        }
                        else
                            _tile[y, x - 1] = TileType.Wall;

                    }
                    // 나머지 빈 공간
                    else
                        _tile[y, x] = TileType.Empty;
                }
                Console.WriteLine();
            }
        }

        //맵 그려주기
        public void Render()
        {
            Player player = new Player();
            ConsoleColor prevColor = Console.ForegroundColor;

            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.ForegroundColor = GetTileColor(_tile[y, x]);
                    if (Console.ForegroundColor == ConsoleColor.White)
                    {
                        Console.Write(SQUARE);
                    }
                    else
                        Console.Write(COIN + " ");
                }
                //Console.Write(y);
                Console.WriteLine();
            }
            CoinNum();
            
            player.PlayerMove();

        }
        // Wall 타입 -> 하얀색, Empty 타입 -> 파랑색
        ConsoleColor GetTileColor(TileType type)
        {
            if (type == TileType.Wall)
            {
                return ConsoleColor.White;
            }
            else if (type == TileType.Empty)
            {
                return ConsoleColor.Blue;
            }
            else
                return 0;
        }

        public int GameScore()
        {
            result = Player.Score;

            return result;
        }
        public void GameScorePrint()
        {
            int x = 30;
            int y = 2;

            Console.CursorLeft = x; Console.CursorTop = y;
            Console.WriteLine("==============");
            y++;
            Console.CursorLeft = x; Console.CursorTop = y;
            Console.Write("점수 : " + result + " / " + CoinNum());
            y++;
            Console.CursorLeft = x; Console.CursorTop = y;
            Console.WriteLine("==============");
            if (result == 48)
            {
                outro.GameKill();
                Console.Clear();
                outro.OutroScene(intro);
            }
        }

        public int CoinNum()
        {
            
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    if ((int)_tile[i, j] == 0)
                    {
                        coinnum++;
                    }
                }
            }
            return coinnum - 1;
        }
    }
}