using System.Collections;
using SimpleMarsRoverKataCSharp.Direction;

namespace SimpleMarsRoverKataCSharp.Tests
{

    public class DirectionTests
    {
        Direction.Direction north = new North();

        [Theory]
        [ClassData(typeof(LeftTestDataGenerator))]
        public void Left_ReturnsTheCorrectDirection(Direction.Direction current, Direction.Direction result)
        {

            Direction.Direction leftFromCurrent = current.Left();

            Assert.Equal(result.Key(), leftFromCurrent.Key());
        }

        [Theory]
        [ClassData(typeof(RightTestDataGenerator))]
        public void Right_ReturnsTheCorrectDirection(Direction.Direction current, Direction.Direction result)
        {
            Direction.Direction rightFromCurrent = current.Right();

            Assert.Equal(result.Key(), rightFromCurrent.Key());

        }

        [Theory]
        [ClassData(typeof(MovementOffsetDataGenerator))]
        public void MovementOffset_ReturnsTheCorrectCoordinates(Direction.Direction direction, Coordinates offset)
        {
            Coordinates resultOffset = direction.MovementOffset();

            Assert.Equal(offset.GetY(), resultOffset.GetY());
            Assert.Equal(offset.GetX(), resultOffset.GetX());
        }

    }

    public class LeftTestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]{ new North(), new West()},
            new object[]{ new West(), new South()},
            new object[]{ new South(), new East()},
            new object[]{ new East(), new North()},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }

    public class RightTestDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]{ new North(), new East()},
            new object[]{ new East(), new South()},
            new object[]{ new South(), new West()},
            new object[]{ new West(), new North()},
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();


        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }


    public class MovementOffsetDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[] {new North(), new Coordinates(0, 1)},
            new object[] {new East(), new Coordinates(1, 0)},
            new object[] {new South(), new Coordinates(0, -1)},
            new object[] {new West(), new Coordinates(-1, 0)}
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
