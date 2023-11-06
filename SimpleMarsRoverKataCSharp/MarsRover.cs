namespace SimpleMarsRoverKataCSharp
{
    public class MarsRover
    {
        Direction.Direction direction;

        public MarsRover(Direction.Direction initialDirection)
        {
            this.direction = initialDirection;
        }

        public void Execute(MarsRoverCommand command)
        {
            if (command.Count() == 0)
            {
                return;
            }

            char step = command.NextStep();

            if (step == 'L')
            {
                this.TurnLeft();
                this.Execute(command);
            }

            if (step == 'R')
            {
                this.TurnRight();
                this.Execute(command);
            }

            this.Execute(command);
        }

        public string SituationReport(Reporter stringReporter)
        {
            return (string)stringReporter.GenerateReport(this);
        }

        public Direction.Direction Facing()
        {
            return this.direction;
        }

        public void TurnLeft()
        {
            this.direction = this.direction.Left();
        }

        public void TurnRight()
        {
            this.direction = this.direction.Right();
        }

    }
}