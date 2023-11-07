using System.Collections;

namespace SimpleMarsRoverKataCSharp.Tests
{
    public class CoordinatesTests
    {
        [Fact]
        public void Coordinates_ShouldHaveThePassedXAndYValues()
        {
            int x = 1;
            int y = 2;

            Coordinates coordinates = new Coordinates(x, y);

            Assert.Equal(x, coordinates.GetX());
            Assert.Equal(y, coordinates.GetY());
        }


        [Fact]
        public void Coordinates_ShouldHaveDefaultValuesIfPassedNone()
        {
            int x = 0;
            int y = 0;

            Coordinates coordinates = new Coordinates();

            Assert.Equal(x, coordinates.GetX());
            Assert.Equal(y, coordinates.GetY());
        }

        [Theory]
        [ClassData(typeof(CombineTestDataGenerator))]
        public void Combine_ShouldReturnCombinesCoordinateValues(Coordinates first, Coordinates second, Coordinates result)
        {
            Coordinates combined = first.Combine(second);

            Assert.Equivalent(combined, result);
        }
    }

    public class CombineTestDataGenerator : IEnumerable<object[]>
    {

        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]{new Coordinates(), new Coordinates(1,1), new Coordinates(1,1) },
            new object[]{ new Coordinates(-1, 1), new Coordinates(1, -1), new Coordinates(0,0) },
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
