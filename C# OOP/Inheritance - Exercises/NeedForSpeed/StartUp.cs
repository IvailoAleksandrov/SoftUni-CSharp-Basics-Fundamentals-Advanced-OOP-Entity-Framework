namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle sportCar = new SportCar(250, 100);
            sportCar.Drive(10);
            System.Console.WriteLine(sportCar.Fuel);
            System.Console.WriteLine(sportCar); // if you want to see more info ovveride to String method
        }
    }
}
