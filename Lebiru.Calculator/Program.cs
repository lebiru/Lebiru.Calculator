using Lebiru.Calculator;

// Welcome message
Console.WriteLine("Welcome to Lebiru.Calculator!");

// Keep running this app unless user stops it
while (true)
{
    // Display menu for user selection
    Console.WriteLine("\nPlease select an operation:");
    Console.WriteLine("1: Addition");
    Console.WriteLine("2: Subtraction");
    Console.WriteLine("3: Multiplication");
    Console.WriteLine("4: Division");
    Console.WriteLine("0: Exit");

    // Await user input
    Console.Write("Enter your choice: ");
    string input = Console.ReadLine();

    // Exit app condition
    if (input == "0")
    {
        Console.WriteLine("Thank you for using the calculator. Goodbye!");
        break;
    }

    // Store the first number if it is really a number
    Console.Write("Enter the first number: ");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    // Store the second number if it is really a number
    Console.Write("Enter the second number: ");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    // Initialize the mathematical operation depending on the switch
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
            // Execute the mathematical operation
            double result = operation.Execute(num1, num2);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            // Display error if execute operation failed
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}