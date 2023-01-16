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
        const char SQUARE = '■';
        const char COIN = '*';

        public TileType[,] _tile;
        public int _size;

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
                    else if(y % 2 == 0 && x < _size - 1)
                    {
                        if(y % 4 == 0)
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
            player.PlayerMove();
        }

        
        ConsoleColor GetTileColor(TileType type)
        {
            if (type == TileType.Wall)
            {
                return ConsoleColor.White;
            }
            else if(type == TileType.Empty)
            {
                return ConsoleColor.Blue;
            }
            else
            return 0; 
        }
        
        
    }
}
