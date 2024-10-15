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
            calculator.UserInput();
        }
    }
}
