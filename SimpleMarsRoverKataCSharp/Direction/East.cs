using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Direction
{
    public class East : Direction
    {
        public Direction Left()
        {
            return new North();
        }

        public Direction Right()
        {
            return new South();
        }

        public string Key()
        {
            return "E";
        }
    }
}
