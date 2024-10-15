public class Calculator : ICalculator
{
    public bool Exit { get; set; }

    public double WriteNumber()
    {
        while (true)
        {
            Console.Write("Enter number: ");
            string? numberString = Console.ReadLine();
            if (double.TryParse(numberString, out double number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Number is invalid. Please enter a valid number.");
            }
        }
    }

    public void AddNumbers()
    {
        Console.Clear();
        Console.WriteLine($"Your number is: {WriteNumber() + WriteNumber()}");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void SubtractNumbers()
    {
        Console.Clear();
        Console.WriteLine($"Your number is: {WriteNumber() - WriteNumber()}");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void MultiplyNumbers()
    {
        Console.Clear();
        Console.WriteLine($"Your number is: {WriteNumber() * WriteNumber()}");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void DivideNumbers()
    {
        Console.Clear();
        Console.WriteLine($"Your number is: {WriteNumber() / WriteNumber()}");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public void UserInput(bool exit)
    {
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Calculator");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    AddNumbers();
                    break;
                case "2":
                    SubtractNumbers();
                    break;
                case "3":
                    MultiplyNumbers();
                    break;
                case "4":
                    DivideNumbers();
                    break;
                case "5":
                    exit = true;
                    break;
            }
        }
    }
}
