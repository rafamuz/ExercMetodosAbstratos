using ExercMetodosAbstratos.Entities;
using ExercMetodosAbstratos.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapeList = new List<Shape>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r / c)? ");
                Char typeShape = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if (typeShape == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapeList.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapeList.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}