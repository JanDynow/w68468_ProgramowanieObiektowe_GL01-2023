using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Shapes
{
    public class Triangle : Shape
    {

        public override void Draw()
        {
            Console.WriteLine($"Draw Triangle {X} {Y} {Width} {Height}");
        }
    }
}