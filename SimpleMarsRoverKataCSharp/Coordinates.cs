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

        public Coordinates Combine(Coordinates other)
        {
            return new Coordinates(this.x + other.GetX(), this.y + other.GetY());
        }
    }
}
