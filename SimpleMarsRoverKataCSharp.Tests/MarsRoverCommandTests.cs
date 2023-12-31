﻿namespace SimpleMarsRoverKataCSharp.Tests
{
    public class MarsRoverCommandTests
    {
        [Fact]
        public void MarsRoverCommand_ShouldHaveAListOfReceivedSteps()
        {
            string steps = "MMM";
            List<char> stepList = new List<char> { 'M', 'M', 'M' };

            MarsRoverCommand command = new MarsRoverCommand(steps);
            List<char> commandSteps = command.GetSteps();

            Assert.Equal(stepList.Count(), command.Count());
            Assert.Equal(stepList, commandSteps);
        }

        [Fact]
        public void NextStep_ShouldReturnTheNextStepAndRemoveItFromTheList()
        {
            string steps = "LRM";
            List<char> stepList = new List<char> { 'R', 'M' };

            MarsRoverCommand command = new MarsRoverCommand(steps);

            char nextStep = command.NextStep();

            Assert.Equal('L', nextStep);
            Assert.Equal(stepList, command.GetSteps());
            Assert.Equal(2, command.Count());
        }

        [Fact]
        public void MarsRoverCommand_ThrowsWhenGivenAnIncorrectStep()
        {
            string steps = "BCS";

            Assert.Throws<ArgumentException>(() => new MarsRoverCommand(steps));
        }
    }
}
