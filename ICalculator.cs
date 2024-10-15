interface ICalculator
{
    /// <summary>
    /// Takes input from the user, checks if the input is a double and returns it.
    /// </summary>
    /// <returns>double number</returns>
    public double WriteNumber();

    /// <summary>
    /// Adds two numbers together and prints the result to the console.
    /// </summary>
    public void AddNumbers();

    /// <summary>
    /// Subtracts two numbers from each other and prints the result to the console.
    /// </summary>
    public void SubtractNumbers();

    /// <summary>
    /// Multiplies two numbers together and prints the result to the console.
    /// </summary>
    public void MultiplyNumbers();

    /// <summary>
    /// Divides two numbers from each other and prints the result to the console.
    /// </summary>
    public void DivideNumbers();

    /// <summary>
    /// Prints a menu to the console and asks the user to choose an option.
    /// Takes input from the user and sends them to the appropriate method in the Calculator class.
    /// If the user inputs 5, the program will exit.
    /// </summary>
    /// <param name="exit"></param>
    public void UserInput(bool exit);
}
