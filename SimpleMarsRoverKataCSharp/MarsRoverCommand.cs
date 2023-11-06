namespace SimpleMarsRoverKataCSharp
{
    public class MarsRoverCommand
    {
        private char[] allowedCommands = new char[] { 'L', 'R', 'M' };

        private List<char> steps = new List<char>();

        public MarsRoverCommand(string command)
        {
            foreach (char step in command)
            {
                steps.Add(this.Validate(step));
            }
        }

        public int Count()
        {
            return this.steps.Count();
        }

        public List<char> GetSteps()
        {
            return steps;
        }

        public char NextStep()
        {
            if (this.Count() == 0)
            {
                throw new InvalidOperationException("No more steps");
            }

            char nextStep = this.steps[0];
            this.steps.RemoveAt(0);

            return nextStep;
        }

        private char Validate(char step)
        {
            if (allowedCommands.Contains(step))
            {
                return step;
            }

            throw new ArgumentException("Command step invalid");
        }
    }
}
