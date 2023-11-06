using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp
{
    public interface Reporter
    {
        public object GenerateReport(MarsRover marsRover);
    }
}
