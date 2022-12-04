public class LProgram
{
    public static void Main()
    {
        Console.WriteLine("0 - Exit\n1 - Addition\n2 - Subtraction\n3 - Multiplication\n4 - Division\n5 - Log\n6 - FromKilometersToMiles");
        string x = Console.ReadLine();
        
        Calculator calculator = new Calculator();
        AdvancedCalc advanced = new AdvancedCalc();

        calculator.num1 = 7;
        calculator.num2 = 3; 
        advanced.num = 5;

        if (x == "1") 
        {
            Console.WriteLine(calculator.Addition());
        }
        else if (x == "2") 
        {
            Console.WriteLine(calculator.Subtraction());
        }
        else if (x == "3") 
        {
            Console.WriteLine(calculator.Multiplication());
        }
        else if (x == "4") 
        {
            Console.WriteLine(calculator.Division());
        }
        else if (x == "5") 
        {
            Console.WriteLine(advanced.Log());
        }
        else if (x == "6") 
        {
            Console.WriteLine(advanced.FromKilometersToMiles());
        }
    }
}
