using System;
using Exercicio6.Entities.Enums;
using Exercicio6.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int numberOfShapes = int.Parse(Console.ReadLine());

            List<Shape> shapeList = new List<Shape>();
            for (int i = 1; i <= numberOfShapes; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shapeType = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (shapeType == 'r')
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
            Console.WriteLine("\nSHAPE AREAS:");
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine($"{shape.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}