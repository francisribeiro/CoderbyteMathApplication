using System;

namespace Math_Application
{
    public class Triangle : Shape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;
        private readonly string name;

        public override string Name { get { return name; } }
        public override double Perimeter { get { return side1 + side2 + side3; } }

        public override double SurfaceArea
        {
            get
            {
                double s = (side1 + side2 + side3) / 2;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            }
        }

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;

            Instance++;

            if ((side1 == side2) && (side2 == side3))
                this.name = "Equilateral Trangle";
            else if ((side1 == side2) || (side1 == side3) || (side2 == side3))
                this.name = "Isosceles Trangle";
            else
                this.name = "Scalene Triangle";
        }
    }
}
