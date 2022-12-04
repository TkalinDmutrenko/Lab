public class Program
{
    public static void Main()
    {
        Console.WriteLine("0 - Exit\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - Log\n6 - FromKilometersToMiles");
        string x = Console.ReadLine();
        
        Calculator calculator = new Calculator();

        calculator.num1 = 7;
        calculator.num2 = 3; 
        calculator.num = 5;
    }
}
