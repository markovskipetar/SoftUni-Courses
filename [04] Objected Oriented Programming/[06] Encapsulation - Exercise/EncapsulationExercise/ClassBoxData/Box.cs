using System;

namespace ClassBoxData
{
    public class Box
    {
        public Box(double length, double width, double height)
        {
            this.Lenght = length;
            this.Width = width;
            this.Height = height;
        }

        private double length;
        private double width;
        private double height;

        public double Lenght
        {
            get
            {
                return this.length;
            }

            set
            {
                Validator.ValidateField(nameof(this.Lenght), value);

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Validator.ValidateField(nameof(this.Width), value);

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                Validator.ValidateField(nameof(this.Height), value);

                this.height = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            double baseArea = this.length * this.width;
            
            double firstSideArea = this.length * this.height;
            double secondSideArea = this.width * this.height;
            
            double totalArea = 2 * baseArea + 2 * firstSideArea + 2 * secondSideArea;

            return totalArea;
        }

        public double CalculateLateralSurfaceArea()
        {
            double firstSideArea = this.length * this.height;
            double secondSideArea = this.width * this.height;

            double totalArea = 2 * firstSideArea + 2 * secondSideArea;

            return totalArea;
        }

        public double CalculateVolume()
        {
            return this.width * this.length * this.height;
        }

        public override string ToString()
        {
            return $"Surface Area - {this.CalculateSurfaceArea():F2}{Environment.NewLine}" +
                $"Lateral Surface Area - {this.CalculateLateralSurfaceArea():F2}{Environment.NewLine}" +
                $"Volume - {this.CalculateVolume():F2}";
        }
    }
}