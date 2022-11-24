using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame
{
    class Board
    {
        private int topCorner = 5;
        private int leftCorner = 7;
        private int height = 20;
        private int width = 30;
        private ConsoleColor backGroundColor = ConsoleColor.Gray;
        private ConsoleColor foregroundColor = ConsoleColor.Yellow;
        private char borderChar = 'X';

        private List<AvailableField> availableFieldsOnBoard = new List<AvailableField>();
        
        public Board()
        {
            CompleteAvailableFields();
        }

        public void Draw()
        {
            Console.Clear();

            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backGroundColor;


            // górna krawedz
            Console.SetCursorPosition(topCorner, leftCorner);
            for (int i = 0; i < width; i++)
            {         
                Console.Write(borderChar);
            }
            //boczna  krawedz
            
            for (int i = 1; i < height - 1; i++)
            {
                // lewa 
                Console.SetCursorPosition(topCorner, i + leftCorner);
                Console.Write(borderChar);

                //prawa
                Console.SetCursorPosition(width - 1 + topCorner, i + leftCorner);
                Console.Write(borderChar);
            }
            //dolna krawedz
            Console.SetCursorPosition(topCorner, height - 1 + leftCorner);
           
            for (int i = 0; i < width; i++)
            {
                Console.Write(borderChar);
            }
            Console.ResetColor();



        }

        public bool CollisionDetect(int x, int y)
        {
            if (y == leftCorner)//górna ściana 
                return true;
            if (x == topCorner)//lewa ściana
                return true;

            if (y == height - 1+leftCorner)//dolna sciana
                return true;
            if (x == width-1+topCorner)//gorna sciana
                return true;

            return false;
        }
        private void CompleteAvailableFields()
        {
            for (int x =topCorner+1; x <= width+topCorner-2; x++)
            {
                for (int y = leftCorner+1; y <= height + leftCorner-2; y++)
                {
                    AvailableField availableField = new AvailableField();
                    availableField.X = x;
                    availableField.Y = y;

                    availableFieldsOnBoard.Add(availableField);
                }
            }
        }
        public AvailableField GetRandomAvaiableField()
        {
            Random random = new Random();

            int randomNumnber = random.Next(0, availableFieldsOnBoard.Count);
            AvailableField availableField = availableFieldsOnBoard[randomNumnber];

            return availableField;
        }
        

    }
}