namespace SimpleMarsRoverKataCSharp.Tests
{
    public class MarsRoverTests
    {
        

        [Theory]
        [InlineData("0:0:N", "")]
        public void Execute_ShouldExecuteTheReceivedCommands(string output, string command)
        {
            MarsRover marsRover = new MarsRover();
            Reporter reporter = new TextReporter();

            marsRover.Execute(new MarsRoverCommand(command));

            string result = marsRover.SituationReport(reporter);

            Assert.Equal(output, result);
        }
    }
}