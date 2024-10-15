namespace Kalkulator
{
    class Program
    {
        /// <summary>
        /// This is the main method that initiates the calculator, and runs the calculator until the user exits.
        /// </summary>
        static void Main(string[] args)
        {
            Calculator calculator = new() { Exit = false };
            while (!calculator.Exit)
            {
                Console.Clear();
                Console.WriteLine("Calculator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                calculator.Exit = calculator.UserInput(calculator.Exit);
            }
        }
    }
}
