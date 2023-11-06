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
            foreach (int step in Enumerable.Range(1, command.Count()))
            {
                if (command.NextStep() == 'L')
                {
                    this.TurnLeft();
                }


            }

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