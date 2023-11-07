using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Direction
{
    public class South : Direction
    {
        public string Key()
        {
            return "S";
        }

        public Direction Left()
        {
            return new East();
        }

        public Coordinates MovementOffset()
        {
            return new Coordinates(0, -1);
        }

        public Direction Right()
        {
            return new West();
        }
    }
}
