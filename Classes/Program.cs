namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Mazda";
            myCar.Model = "CX5";
            myCar.Year = 2019;

            Console.WriteLine($"The car is a {myCar.Make} {myCar.Model} from {myCar.Year}");

        }
    }
}
