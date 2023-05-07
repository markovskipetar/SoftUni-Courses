using System;

namespace PointInRectangle
{
    class Rectangle
    {
        public Rectangle(int topLeftX, int topLeftY, int bottomRightX, int bottomRightY)
        {
            this.TopLeftCoordinates = new Point(topLeftX, topLeftY);
            this.BottomRightCoordinates = new Point(bottomRightX, bottomRightY);
        }

        public Point TopLeftCoordinates { get; set; }
        public Point BottomRightCoordinates { get; set; }

        public bool IsPointInside(Point point)
        {
            int topLeftX = this.TopLeftCoordinates.X;
            int topLeftY = this.TopLeftCoordinates.Y;

            int bottomRightX = this.BottomRightCoordinates.X;
            int bottomRightY = this.BottomRightCoordinates.Y;

            int pointX = point.X;
            int pointY = point.Y;

            bool isInside = (pointX >= topLeftX && pointY >= topLeftY) && (pointX <= bottomRightX && pointY <= bottomRightY);

            return isInside;
        }
    }
}
