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
    }
}
