using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp.Tests
{
    public class RectangularWrappingBoundaryTests
    {
        [Fact]
        public void RectangularWrappingBoundary_ShouldTellIfCoordinatesAreOutOfBounds()
        {
            Boundary boundary = new RectangularWrappingBoundary(0,0,1,1);
            Coordinates inBounds = new Coordinates(boundary, 0, 1);
            Coordinates outOfBounds = new Coordinates(boundary, 2, 2);

            Assert.False(boundary.IsOutOfBounds(inBounds));
        }

        [Fact]
        public void HandleOutOfBounds_ShouldWrapOutOfBoundsCoordinates()
        {
            Boundary boundary = new RectangularWrappingBoundary(0,0,3,3);
            Coordinates outOfBounds = new Coordinates(boundary,-1, 4);
            Coordinates expectedWrap = new Coordinates(boundary,3, 0);

            Coordinates wrappedCoordinates = boundary.HandleOutOfBounds(outOfBounds);

            Assert.Equal(expectedWrap.GetX(), wrappedCoordinates.GetX());
            Assert.Equal(expectedWrap.GetY(), wrappedCoordinates.GetY());

        }
    }
}
