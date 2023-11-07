using System.Collections;

namespace SimpleMarsRoverKataCSharp.Tests
{
    public class CoordinatesTests
    {
        Boundary boundary = new RectangularWrappingBoundary(0, 0, 5, 5);

        [Fact]
        public void Coordinates_ShouldHaveThePassedXAndYValues()
        {
            int x = 1;
            int y = 2;


            Coordinates coordinates = new Coordinates(this.boundary, x, y);

            Assert.Equal(x, coordinates.GetX());
            Assert.Equal(y, coordinates.GetY());
        }


        [Theory]
        [ClassData(typeof(MoveTestDataGenerator))]
        public void Move_ShouldReturnUpdatedCoordinateValues(Coordinates initial, Movement movement, Coordinates result)
        {
            Coordinates movedCoordinates = initial.Move(movement);

            Assert.Equal(movedCoordinates.GetX(), result.GetX());
            Assert.Equal(movedCoordinates.GetY(), result.GetY());
        }
    }

    public class MoveTestDataGenerator : IEnumerable<object[]>
    {
        


        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]{new Coordinates(new RectangularWrappingBoundary(0, 0, 5, 5), 0, 0), new Movement(1,1), new Coordinates(new RectangularWrappingBoundary(0, 0, 5, 5), 1,1) },
            new object[]{ new Coordinates(new RectangularWrappingBoundary(0, 0, 5, 5), -1, 1), new Movement(1, -1), new Coordinates(new RectangularWrappingBoundary(0, 0, 5, 5), 0,0) },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
