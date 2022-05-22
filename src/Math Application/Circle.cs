using System;

namespace Math_Application
{
    public class Circle : Shape
    {
        private readonly double radius;

        public override string Name { get { return "Circle"; } }
        public override double Perimeter{ get { return 2.0 * Math.PI * radius; } }
        public override double SurfaceArea { get { return Math.PI * radius * radius; } }

        public Circle(double radius) {
            this.radius = radius;

            Instance++;
        }
    }
}
