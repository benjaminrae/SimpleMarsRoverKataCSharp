using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Direction
{
    public class South : Direction
    {
        public Direction Left()
        {
            return new East();
        }

        public Direction Right()
        {
            return new West();
        }
    }
}
