namespace SimpleMarsRoverKataCSharp
{
    public class Coordinates
    {
        private int x;
        private int y;
        private Boundary boundary;

        public Coordinates( Boundary boundary, int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
            this.boundary = boundary;

            if (this.boundary.IsOutOfBounds(this))
            { 
            Coordinates adjustedCoordinates = this.boundary.HandleOutOfBounds(this);
                this.x = adjustedCoordinates.GetX();
                this.y = adjustedCoordinates.GetY();
            }

        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public Coordinates Move(Movement movement)
        {
            return new Coordinates(this.boundary, this.x + movement.XChange(), this.y + movement.YChange());
        }
    }
}
