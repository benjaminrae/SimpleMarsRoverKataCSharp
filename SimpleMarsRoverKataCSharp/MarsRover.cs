namespace SimpleMarsRoverKataCSharp
{
    public class MarsRover
    {
        private Direction.Direction direction;
        private Coordinates position;

        public MarsRover(Direction.Direction initialDirection, Coordinates initialPosition)
        {
            this.direction = initialDirection;
            this.position = initialPosition;
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

        public Coordinates Position()
        {
            return this.position;
        }

        public void MoveForward()
        {

        }

    }
}