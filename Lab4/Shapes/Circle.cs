using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Shapes
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Draw Circle {X} {Y} {Width} {Height}");
        }
    }
}