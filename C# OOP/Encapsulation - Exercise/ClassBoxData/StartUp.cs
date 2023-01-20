using System;
using System.Globalization;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);
                //double result1 = box.SurfaceArea();
                //double result2 = box.LateralSurfaceArea();
                //double result3 = box.Volume();
                //Console.WriteLine($"Surface Area - {result1:f2}");
                //Console.WriteLine($"Lateral Surface Area - {result2:f2}");
                //Console.WriteLine($"Volume - {result3:f2}");
                Console.WriteLine(box);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            




        }
    }
}
