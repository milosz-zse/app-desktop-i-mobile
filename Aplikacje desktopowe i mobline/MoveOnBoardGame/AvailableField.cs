using MoveOnBoardGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame
{
    class AvailableField
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TypeOfObstacle TypeOfObstacle { get; set; }
    }
}