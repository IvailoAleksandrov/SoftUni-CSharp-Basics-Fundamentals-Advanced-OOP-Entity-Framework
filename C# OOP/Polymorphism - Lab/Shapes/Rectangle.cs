using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double Height
        {
            get { return height; }
            private set { height = value; }
        }
        public double Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }
        public override double CalculateArea()
        {
            return Width* Height;
        }

        public override double CalculatePerimeter()
        {
            return Width*2 + Height*2;
        }
        public override string Draw()
        {
            return base.Draw() + " Rectangle";
        }
    }
}
