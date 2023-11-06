using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Direction
{
    public class North : Direction
    {
        public Direction Left()
        {
            return new West();
        }

        public Direction Right()
        {
            return new East();
        }
    }
}
