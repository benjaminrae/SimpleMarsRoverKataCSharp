using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Direction
{
    public class West : Direction
    {
        public string Key()
        {
            return "W";
        }

        public Direction Left()
        {
            return new South();
        }

        public Coordinates MovementOffset()
        {
            return new Coordinates(-1, 0);
        }

        public Direction Right()
        {
            return new North();
        }
    }
}
