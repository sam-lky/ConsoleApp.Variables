namespace ConsoleApp.NameDeclaration
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // different datatypes
            /*
            text - integer
            integers - int
            decimal - double,float, decimal
            logical - bool
             */
             
            string name = "Charles LeClare";
            
            Console.WriteLine(name);
            Console.WriteLine($"I am The {name}"); // string interpolation
            Console.WriteLine("I am THE " + name); // string concatenation
            Console.WriteLine("I was given the name {0}", name); // Formatted string 

            int age = 55;
            int retirementYearsLeft = 15;
            int retirementAge = age + retirementYearsLeft;
            Console.WriteLine("My age is " + age);
            Console.WriteLine($"My retirementAge is {retirementAge}");

            bool isRetired = false;
            Console.WriteLine("Is this fella retired " + isRetired);
        }
    }
}
