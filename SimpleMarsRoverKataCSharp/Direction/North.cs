using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Direction
{
    public class North : Direction
    {
        public string Key()
        {
            return "N";
        }

        public Direction Left()
        {
            return new West();
        }

        public Movement MovementOffset()
        {
            return new Movement(0, 1);
        }

        public Direction Right()
        {
            return new East();
        }
    }
}
