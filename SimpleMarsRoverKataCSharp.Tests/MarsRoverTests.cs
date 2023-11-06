using SimpleMarsRoverKataCSharp.Direction;

namespace SimpleMarsRoverKataCSharp.Tests
{
    public class MarsRoverTests
    {
        

        [Theory]
        [InlineData("0:0:N", "")]
        [InlineData("0:0:W", "L")]
        public void Execute_ShouldExecuteTheReceivedCommands(string output, string command)
        {
            Direction.Direction initialDirection = new North();
            MarsRover marsRover = new MarsRover(initialDirection);
            Reporter reporter = new TextReporter();

            marsRover.Execute(new MarsRoverCommand(command));

            string result = marsRover.SituationReport(reporter);

            Assert.Equal(output, result);
        }
    }
}