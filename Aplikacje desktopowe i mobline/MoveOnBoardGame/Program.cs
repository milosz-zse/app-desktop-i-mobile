using System;
using System.Threading;

namespace MoveOnBoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                - gracz
                - plansza
                
             */

            Board board = new Board();
            board.Draw();

            Player player = new Player();

            char direction = 's';

            while (true)
            {
                player.Move();
                if (board.CollisionDetect(player.CurrX , player.CurrY))
                {
                    break;
                }
                Thread.Sleep(500);
            }
        }
    }
}