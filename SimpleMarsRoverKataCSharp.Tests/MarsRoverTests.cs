using SimpleMarsRoverKataCSharp.Direction;

namespace SimpleMarsRoverKataCSharp.Tests
{
    public class MarsRoverTests
    {


        [Theory]
        [InlineData("0:0:N", "")]
        [InlineData("0:0:W", "L")]
        [InlineData("0:0:E", "R")]
        [InlineData("0:0:S", "LRRRRL")]
        [InlineData("0:1:N", "M")]
        [InlineData("2:2:N", "RMLMRMLM")]
        public void Execute_ShouldExecuteTheReceivedCommands(string output, string command)
        {
            Boundary boundary = new RectangularWrappingBoundary(0, 0, 5, 5);
            Direction.Direction initialDirection = new North();
            Coordinates initialPosition = new Coordinates(boundary, 0, 0);
            MarsRover marsRover = new MarsRover(initialDirection, initialPosition);
            Reporter reporter = new TextReporter();

            marsRover.Execute(new MarsRoverCommand(command));

            string result = marsRover.SituationReport(reporter);

            Assert.Equal(output, result);
        }
    }
}