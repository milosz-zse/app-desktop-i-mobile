using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame
{
    class Board
    {
        private int height = 20;
        private int width = 30;
        private ConsoleColor backGroundColor = ConsoleColor.Gray;
        private ConsoleColor foregroundColor = ConsoleColor.Yellow;
        private char borderChar = 'X';

        public Board()
        {

        }

        public void Draw()
        {
            Console.Clear();

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGroundColor;

            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }

            for (int i = 1; i < height - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(borderChar);

                Console.SetCursorPosition(width - 1, i);
                Console.Write(borderChar);
            }

            Console.SetCursorPosition(0, height - 1);
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }
            Console.ResetColor();



        }

        public bool CollisionDetect(int x, int y)
        {
            if (y == 0)//górna ściana 
                return true;
            if (x == 0)//lewa ściana
                return true;

            if (y == height - 1)//dolna sciana
                return true;
            if (x == width)//gorna sciana
                return true;

            return false;
        }
    }
}