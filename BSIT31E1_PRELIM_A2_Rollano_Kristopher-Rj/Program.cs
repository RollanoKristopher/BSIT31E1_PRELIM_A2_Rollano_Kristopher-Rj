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

    Console.WriteLine("Enter Second Numner: ");
    string secondInput = Console.ReadLine();

    Console.WriteLine("Enter Operator ( +, -, *, /): ");
    string Operator = Console.ReadLine();
   
}