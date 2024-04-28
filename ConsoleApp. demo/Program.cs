// Declare variable
using System.Runtime.CompilerServices;

string firstname = string.Empty;
string lastname = string.Empty;
int age = 0;
int retirementAge = 70;

// Prompt user for input
Console.WriteLine("Pleasse enter your first name");
name = Console.ReadLine();

Console.WriteLine("Pleasse enter your last name");
name = Console.ReadLine();

Console.WriteLine("Pleasse enter your age");
age = Convert.ToInt32(Console.ReadLine());

// Process the data
int workingYearsRemaining = retirementAge - age;

// Output the result to the user
Console.WriteLine($"Full name: {firstname} {lastname}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Working years remaining = {workingYearsRemaining}");