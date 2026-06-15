while (true)
{
    Console.WriteLine("Enter Fist Number (or 'Exit' to quit): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        
    {
        //CODE
        Console.WriteLine("Calculator closed.");
        break;

    }
    if (!double.TryParse(input, out double num1))
        {
        Console.WriteLine("Invalid number.");
        continue;
    }

    Console.Write("Enter Second Numner: ");
    string secondInput = Console.ReadLine();
    
    if (!double.TryParse(secondInput, out double num2))

{
    Console.WriteLine("Invalid number.");
    continue;
}

Console.WriteLine("Enter Operator ( +, -, *, /): ");
    string Operator = Console.ReadLine();

    double result = 0;


    if (Operator == "+")
    {
        result = num1 + num2;
    }
    else if (Operator == "-")
    {
        result = num1 - num2;
    }
    else if (Operator == "*")
    {
        result = num1 * num2;
    }
    else if (Operator == "/")
    {
        if (num2 == 0)
        {
            Console.WriteLine("Invalid.");
            continue;
        }

        result = num1 / num2; 

        }
    else
    {
        Console.WriteLine("Invalid Operator.");
        continue;
    }
    Console.WriteLine($"Result: {result}");
}