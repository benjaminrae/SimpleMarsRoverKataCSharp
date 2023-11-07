using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Tests
{
    public class BoundaryTests
    {
        [Fact]
        public void RectangularWrappingBoundary_ShouldTellIfCoordinatesAreOutOfBounds()
        {
            Coordinates bottomLeft = new Coordinates(0, 0);
            Coordinates topRight = new Coordinates(1, 1);
            Coordinates inBounds = new Coordinates(0, 1);
            Coordinates outOfBounds = new Coordinates(2, 2);
            Boundary boundary = new RectangularWrappingBoundary(bottomLeft, topRight);

            Assert.True(boundary.IsOutOfBounds(outOfBounds));   
            Assert.False(boundary.IsOutOfBounds(inBounds));
        }

        [Fact]
        public void Wrap_ShouldWrapOutOfBoundsCoordinates()
        {
            Coordinates bottomLeft = new Coordinates(0, 0);
            Coordinates topRight = new Coordinates(3, 3);
            Coordinates outOfBounds = new Coordinates(-1, 4);
            Coordinates expectedWrap = new Coordinates(3, 0);
            WrappingBoundary boundary = new RectangularWrappingBoundary(bottomLeft, topRight);

            Coordinates wrappedCoordinates = boundary.Wrap(outOfBounds);

            Assert.Equal(expectedWrap.GetX(), wrappedCoordinates.GetX());
            Assert.Equal(expectedWrap.GetY(), wrappedCoordinates.GetY());

        }
    }
}
