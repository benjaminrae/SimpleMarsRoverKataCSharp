using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Tests
{
    public class MovementTests
    {
        [Fact]
        public void Movement_ShouldHaveTheReceivedXChangeAndYChange()
        {
            Movement movement = new Movement(1, 0);

            Assert.Equal(1, movement.XChange());
            Assert.Equal(0, movement.YChange());

        }
    }
}
