namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.Make = "Land Rover";
            myCar.Model = "Discovery";
            myCar.Year = 2017;

            Console.WriteLine($"I drive a {myCar.Year}{myCar.Make}{myCar.Make} and I love it.");
        }
    }
}
