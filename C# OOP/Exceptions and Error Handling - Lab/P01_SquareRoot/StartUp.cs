using System;

namespace P01_SquareRoot
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
			try
			{
                int number = int.Parse(Console.ReadLine());
				Calculator calculator = new Calculator();
				Console.WriteLine(calculator.Sqrt(number));
            }
			catch (ArgumentException ex)
			{
                Console.WriteLine(ex.ParamName, ex.Message);
            }
			finally
			{
                Console.WriteLine("Good bye");
            }
        }
    }

}
