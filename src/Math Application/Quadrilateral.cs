namespace Math_Application
{
    public class Quadrilateral : Shape
    {
        private readonly double width;
        private readonly double length;
        private readonly string name;

        public override string Name { get { return name; } }
        public override double Perimeter { get { return (width * length) / 2; } }
        public override double SurfaceArea { get { return width * length; } }

        public Quadrilateral(double width, double length)
        {
            this.width = width;
            this.length = length;

            Instance++;

            if (width == length)
                this.name = "Square";
            else
                this.name = "Rectangle";
        }
    }
}
