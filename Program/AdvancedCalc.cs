public class AdvancedCalc : Calculator
{
    public double num;

    public double Log()
    {
        return Math.Log10(num);
    }

    public double FromKilometersToMiles()
    {
        return num / 1.609;
    }
}