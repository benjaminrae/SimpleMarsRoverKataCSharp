namespace SimpleMarsRoverKataCSharp
{
    public class Movement
    {
        private int x;
        private int y;

        public Movement(int xChange, int yChange)
        {
            this.x = xChange;
            this.y = yChange;
        }

        public int XChange()
        {
            return this.x;
        }

        public int YChange()
        {
            return this.y;
        }
    }
}