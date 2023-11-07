using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Direction
{
    public interface Direction
    {
        Direction Left();
        Direction Right();
        string Key();
        Coordinates MovementOffset();
    }
}
