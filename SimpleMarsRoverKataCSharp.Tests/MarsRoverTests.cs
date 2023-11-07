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
        public void Execute_ShouldExecuteTheReceivedCommands(string output, string command)
        {
            Direction.Direction initialDirection = new North();
            Coordinates initialPosition = new Coordinates();
            MarsRover marsRover = new MarsRover(initialDirection, initialPosition);
            Reporter reporter = new TextReporter();

            marsRover.Execute(new MarsRoverCommand(command));

            string result = marsRover.SituationReport(reporter);

            Assert.Equal(output, result);
        }
    }
}