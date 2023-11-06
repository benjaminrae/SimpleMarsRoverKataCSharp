namespace SimpleMarsRoverKataCSharp
{
    public class MarsRover
    {
        public void Execute(MarsRoverCommand command)
        {
            
        }

        public string SituationReport(Reporter stringReporter)
        {
            return (string)stringReporter.GenerateReport(this);
        }
    }
}