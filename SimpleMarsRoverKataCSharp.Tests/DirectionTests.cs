using SimpleMarsRoverKataCSharp.Direction;
using System.Collections;

namespace SimpleMarsRoverKataCSharp.Tests
{
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

    public class DirectionTests
    {
        Direction.Direction north = new North();

        [Theory]
        [ClassData(typeof(LeftTestDataGenerator))]
        public void Left_ReturnsTheCorrectDirection(Direction.Direction current, Direction.Direction result)
        {

            Direction.Direction leftFromCurrent = current.Left();

            Assert.Equivalent(result, leftFromCurrent);
        }

        [Theory]
        [ClassData(typeof(RightTestDataGenerator))]
        public void Right_ReturnsTheCorrectDirection(Direction.Direction current, Direction.Direction result)
        {
            Direction.Direction rightFromCurrent = current.Right();

            Assert.Equivalent(result, rightFromCurrent);

        }

    }
}
