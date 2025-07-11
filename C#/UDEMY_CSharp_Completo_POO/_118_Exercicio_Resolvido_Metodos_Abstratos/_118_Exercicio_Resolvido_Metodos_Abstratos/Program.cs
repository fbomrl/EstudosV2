﻿using _118_Exercicio_Resolvido_Metodos_Abstratos.Entities;
using _118_Exercicio_Resolvido_Metodos_Abstratos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace _118_Exercicio_Resolvido_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                //Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
