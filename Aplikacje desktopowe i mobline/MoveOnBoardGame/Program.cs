using System;
using System.Threading;


namespace MoveOnBoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Draw();
            AvailableField availableField = board.GetRandomAvaiableField();
            Player player = new Player(availableField.X,availableField.Y);

                 MoveDirection direction = MoveDirection.MOVE_RIGHT;
          
                 while (true)
                 {
                     if (Console.KeyAvailable)
                     {
                         direction = (MoveDirection)Console.ReadKey(true).KeyChar;
                     }

                     player.Move(direction);
                     if(board.CollisionDetect(player.CurrX, player.CurrY))
                     {
                         break;
                     }
                     Thread.Sleep(100);
                 }
            
                 
        

        }
    }
}