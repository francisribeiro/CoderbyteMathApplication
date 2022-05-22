using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Math_Application
{
    static class Program
    {
        static void Main()
        {
            // Create list of Shape objects and call PopulateShapes() to populate list.
            List<Shape> ourShapes = PopulateShapes();
            Console.WriteLine("\n#================================#");
            Console.WriteLine("    Shapes have been created    ");
            Console.WriteLine("#================================#\n");
            Shape.PrintShape(ourShapes.ToList());

            // Q5 Handled here
            Console.WriteLine("\n#================================#");
            Console.WriteLine("     Shapes ordered by Area     ");
            Console.WriteLine("#================================#\n");

            // Create a temp variable to store the array and soft the array based on its SurfaceArea using Lamba expression
            var orderedByArea = ourShapes.OrderBy(o => o.SurfaceArea).ToList();

            // Print ordered List
            Shape.PrintShape(orderedByArea.ToList());

            Console.WriteLine("\n#================================#");
            Console.WriteLine("     Shapes ordered by Perimeter   ");
            Console.WriteLine("#================================#\n");

            // Create a temp variable to store the array and soft the array based on its Perimeter using Lamba expression
            var orderedByPerimeter = ourShapes.OrderBy(p => p.Perimeter).ToList();

            // Print ordered List
            Shape.PrintShape(orderedByPerimeter.ToList());

            // Q6 Handled here
            Console.WriteLine("\n#================================#");
            Console.WriteLine("    Shapes now in Json Format    ");
            Console.WriteLine("#================================#\n");

            // Open FileStream and create JSON.txt file
            using (FileStream fs = File.Create("JSON.txt"))
            {
                JsonSerializer.SerializeAsync(fs, ourShapes);
            }

            // Save the option to have the JSON file formatter set as true
            var options = new JsonSerializerOptions { WriteIndented = true };

            // Serialise the List of Shapes, with the formatter option into a string
            string strJson = JsonSerializer.Serialize<IList<Shape>>(ourShapes, options);

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JSON.txt");

            File.WriteAllText(path, strJson);
            Console.WriteLine("JSON file is being read and stored in Directory as JSON.txt \n\n" + File.ReadAllText("JSON.txt"));

            // Q7 Handled here
            Console.WriteLine("\n#================================#");
            Console.WriteLine("    Number of Instaces of Shape    ");
            Console.WriteLine("#================================#\n");

            // Display how many instances of object Shape there is created.
            Console.WriteLine(Shape.Instance);
        }


        private static List<Shape> PopulateShapes()
        {
            var shapes = new List<Shape>();

            // Q1 ,Q2, Q3 and Q4 Handled here

            // Generate Shapes

            Circle circle = new(5);
            Triangle equilateralTriangle = new(10, 10, 10);
            Triangle isoscelesTriangle = new(15, 15, 5);
            Triangle scaleneTriangle = new(10, 8, 6);
            Quadrilateral square = new(10, 10);
            Quadrilateral rectangle = new(10, 6);

            // Add shapes to list of type Shape
            shapes.Add(circle);
            shapes.Add(equilateralTriangle);
            shapes.Add(isoscelesTriangle);
            shapes.Add(scaleneTriangle);
            shapes.Add(square);
            shapes.Add(rectangle);

            return shapes;
        }
    }
}
