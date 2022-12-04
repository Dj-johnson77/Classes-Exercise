namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Chevrolet";
            myCar.Model = "Corvette";
            myCar.Year = 2020;

            Console.WriteLine("Car Make : Car Model: Car Year");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{myCar.Make} : {myCar.Model} : {myCar.Year}");

        }
    }
}
