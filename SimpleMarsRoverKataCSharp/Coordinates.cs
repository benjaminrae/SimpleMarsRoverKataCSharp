namespace SimpleMarsRoverKataCSharp
{
    public class Coordinates
    {
        private int x;
        private int y;

        public Coordinates(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
