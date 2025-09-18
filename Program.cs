// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

// Approach 1: If/Else
Console.WriteLine("Approach 1: If/Else");
for (int i = 1; i <= number; i++)
{
    // Approach 1:
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

// Approach 2: String Concatenation
Console.WriteLine("Approach 2: String Concatenation");

for (int i = 1; i <= number; i++)
{
    string output = "";

    if (i % 3 == 0) output += "Fizz";
    if (i % 5 == 0) output += "Buzz";
    if (output == "") output = i.ToString();

    Console.WriteLine(output);
}

// Approach 3: Dictionary Mapping
Console.WriteLine("Approach 3: Dictionary Mapping");

var mapping = new Dictionary<int, string>
{
    { 3, "Fizz" },
    { 5, "Buzz" }
};

for (int i = 1; i <= number; i++)
{
    string output = "";
    foreach (var kvp in mapping)
    {
        if (i % kvp.Key == 0) output += kvp.Value;
    }
    if (output == "") output = i.ToString();
    
    Console.WriteLine(output);
}
