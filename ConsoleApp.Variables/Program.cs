namespace ConsoleApp.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Different datatypes
            /*
             text - string
            integers - int
            decimal - double, float, decimal
            logical - bool 
            */
            string name = "Charles LeClare";
            Console.WriteLine(name);
            Console.WriteLine($"I am The {name}"); // string interpolation
            Console.WriteLine("I am The" + name); // string concatention 
            Console.WriteLine("You can call me {0}", name); // formatted string
        }
    }
}
