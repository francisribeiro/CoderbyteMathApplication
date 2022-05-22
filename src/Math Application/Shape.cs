using System;
using System.Collections.Generic;

namespace Math_Application
{
    public abstract class Shape
    {
        public static int Instance;

        public abstract string Name { get; }
        public abstract double Perimeter { get; }
        public abstract double SurfaceArea { get; }

        public static double GetArea(Shape shape) => shape.SurfaceArea;
        public static double GetPerimeter(Shape shape) => shape.Perimeter;

        public static void PrintShape(List<Shape> shape)
        {
            int i = 1;

            foreach (var s in shape)
            {
                Console.WriteLine(i + ") " + $"{s.Name}: Area = {GetArea(s)}; " + $"Perimeter = {GetPerimeter(s)};");
                i++;
            }
        }
    }
}
