using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp
{
    public class TextReporter : Reporter
    {
        public object GenerateReport(MarsRover marsRover)
        {
            Direction.Direction direction = marsRover.Facing();
            int x = marsRover.Position().GetX();
            int y = marsRover.Position().GetY();

            return $"{x}:{y}:{direction.Key()}";
        }
    }
}
