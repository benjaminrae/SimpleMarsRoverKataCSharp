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

            return $"0:0:{direction.Key()}";
        }
    }
}
