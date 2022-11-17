using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame 
{
    class Player 
    {
        private ConsoleColor backGroundColor = ConsoleColor.DarkMagenta;
        private ConsoleColor foregroundColor = ConsoleColor.Black;
        private char playerChar = 'O';



        private int currX = 1;
        private int currY = 1;

        private int prevX = 1;
        private int prevY = 1;

        //propertis 2
        public int CurrX
        {
            get
            {
                return currX;
            }
        }
        public int CurrY
        {
            get
            {
                return currY;
            }
        }
        public Player()
        {
            Draw();
        }

        public void Move(char direction)
        {
            //char presKey = Console.ReadKey(true).KeyChar;

            switch (direction)
            {
                case moveUp:
                    currY--;
                    break;
                case moveDown:
                    currY++;
                    break;
                case moveLeft:
                    currX--;
                    break;
                case moveRight:
                    currX++;
                    break;
                default:
                    break;
            }

            Draw();
        }

        private void Draw()
        {
            Console.ResetColor();
            Console.SetCursorPosition(prevX, prevY);
            Console.Write(' ');

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGroundColor;
            Console.SetCursorPosition(currX, currY);
            Console.Write(playerChar);

            prevX = currX;
            prevY = currY;

            Console.ResetColor();
        }

    }
}
