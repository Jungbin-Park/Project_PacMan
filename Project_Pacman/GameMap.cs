using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Project_Pacman;


namespace Project_PacMan
{
    public class GameMap
    {
        private Outro outro = new Outro();

        const char SQUARE = '■';
        const char COIN = '*';

        static public TileType[,] _tile;
        public int _size;

        public static int result;         //총점
        public static int coinnum = 0;    //동전개수('*'개수)
        

        public enum TileType
        {
            Empty,
            Wall,
        }

        public void Initialize(int size)
        {
            _tile = new TileType[size, size];
            _size = size;

            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    if (x == 0 || x == _size - 1 || y == 0 || y == _size - 1)
                    {
                        _tile[y, x] = TileType.Wall;

                    }
                    else if (y % 2 == 0)
                    {
                        if (y % 4 == 0 && x < _size - 1)
                        {
                            _tile[y, x + 1] = TileType.Wall;

                        }
                        else
                            _tile[y, x - 1] = TileType.Wall;

                    }
                    else
                        _tile[y, x] = TileType.Empty;
                }
                Console.WriteLine();
            }

        }

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

            Console.Write("점수 : " + result + " / " + CoinNum());
            if(result == 48)
            {
                outro.GameKill();
                Console.Clear();
                outro.OutroScene();
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