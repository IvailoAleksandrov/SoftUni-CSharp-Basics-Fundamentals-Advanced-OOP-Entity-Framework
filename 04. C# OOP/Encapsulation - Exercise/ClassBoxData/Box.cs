using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        public double Lenght
        {
            get { return lenght; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }
        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
                height = value; 
            }
        }
            //        Volume = lwh
            //Lateral Surface Area = 2lh + 2wh
            //Surface Area = 2lw + 2lh + 2wh
        public double SurfaceArea()
        {
            return (2 * Lenght * Width) + (2 * Lenght * Height) + (2 * Width * Height);
        }
        public double LateralSurfaceArea()
        {
            return (2 * Lenght * Height + (2 * Width * Height));
        }
        public double Volume()
        {
            return Lenght * Height * Width;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():F2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():F2}");
            sb.AppendLine($"Volume - {Volume():F2}");
            return sb.ToString().TrimEnd();
        }
    }
}
