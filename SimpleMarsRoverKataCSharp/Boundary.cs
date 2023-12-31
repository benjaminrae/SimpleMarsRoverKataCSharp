﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMarsRoverKataCSharp
{
    public interface Boundary
    {
        bool IsOutOfBounds(Coordinates coordinates);
        Coordinates HandleOutOfBounds(Coordinates coordinates);
    }

    public class RectangularWrappingBoundary : Boundary
    {
        private int upperX;
        private int lowerX;
        private int upperY;
        private int lowerY;

        public RectangularWrappingBoundary(int lowerX, int lowerY, int upperX, int upperY) {
            this.upperY = upperY;
            this.lowerY = lowerY;
            this.upperX = upperX;
            this.lowerX = lowerX;
        }

        public bool IsOutOfBounds(Coordinates coordinates)
        {
            int x = coordinates.GetX();
            int y = coordinates.GetY();

            if (this.IsBelowX(x) ||  this.IsAboveX(x))
            {
                return true;
            }

            if (this.IsBelowY(y) || this.IsAboveY(y))
            {
                return true;
            }

            return false;
        }


        public Coordinates HandleOutOfBounds(Coordinates coordinates)
        {
            int xDifference = this.CalculateXDifference(coordinates.GetX());
            int yDifference = this.CalculateYDifference(coordinates.GetY());

            return coordinates.Move(new Movement(xDifference, yDifference));
        }

        private int CalculateXDifference(int x)
        {
            int width = Math.Abs(upperX - lowerX +1);

            if (IsBelowX(x)) {
                return width;
            }

            if (IsAboveX(x))
            {
                return width * -1;
            }

            return 0;
        }

        private int CalculateYDifference(int y)
        {
            int height = Math.Abs(upperX-lowerX+1);

            if (IsBelowY(y))
            {
                return height;
                
            }

            if (IsAboveX(y))
            {
                return height * -1;
            }

            return 0;

        }

        private bool IsBelowX(int x)
        {
            return (x < lowerX);
        }

        public bool IsBelowY(int y)
        {
            return (y < lowerY);
        }

        public bool IsAboveX(int x)
        {
            return (x > upperX);
        }

        public bool IsAboveY(int y)
        {
            return (y > upperY);
        }
    }
}
