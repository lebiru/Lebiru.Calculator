using Lebiru.Calculator;

Console.WriteLine("Welcome to the Simple Calculator!");

while (true)
{
    Console.WriteLine("\nPlease select an operation:");
    Console.WriteLine("1: Addition");
    Console.WriteLine("2: Subtraction");
    Console.WriteLine("3: Multiplication");
    Console.WriteLine("4: Division");
    Console.WriteLine("0: Exit");

    Console.Write("Enter your choice: ");
    string input = Console.ReadLine();

    if (input == "0")
    {
        Console.WriteLine("Thank you for using the calculator. Goodbye!");
        break;
    }

    Console.Write("Enter the first number: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    Console.Write("Enter the second number: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    IOperation operation = input switch
    {
        "1" => new Addition(),
        "2" => new Subtraction(),
        "3" => new Multiplication(),
        "4" => new Division(),
        _ => null
    };

    if (operation == null)
    {
        Console.WriteLine("Invalid choice. Please select a valid operation.");
    }
    else
    {
        try
        {
            double result = operation.Execute(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}