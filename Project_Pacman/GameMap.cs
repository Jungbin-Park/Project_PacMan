using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Project_PacMan
{
    public class GameMap
    {
        const char SQUARE = '■';

        public TileType[,] _tile;
        public int _size;

        public enum TileType
        {
            Emtpy,
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
                        _tile[y, x] = TileType.Wall;
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
                    _tile[y, x] = TileType.Emtpy;
                }
            }
        }

        public void Render()
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            
            for (int y = 0; y < _size; y++)
            {
                for (int x = 0; x < _size; x++)
                {
                    Console.ForegroundColor = GetTileColor(_tile[y, x]);
                    Console.Write(SQUARE);
                }
                Console.WriteLine();
            }
        }

        
        ConsoleColor GetTileColor(TileType type)
        {
            if (type == TileType.Wall)
            {
                return ConsoleColor.White;
            }
            else
                return 0;
        }
        
    }
}
