public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        calculator.num1 = 7;
        calculator.num2 = 3; 

        Console.WriteLine(calculator.Division());

        AdvancedCalc advanced = new AdvancedCalc();

        advanced.num = 5;

        Console.WriteLine(advanced.Log())
    }
}
