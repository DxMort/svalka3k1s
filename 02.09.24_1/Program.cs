public class CustomConverter
{
    public void Converty(string input, out int result)
    {
        result = Convert.ToInt32(input);
    }

    public void Converty(string input, out double result)
    {
        result = Convert.ToDouble(input);
    }

    public void Converty(string input, out bool result, out int intV2)
    {
        result = Convert.ToBoolean(input);
        intV2 = Convert.ToInt32(result);
    }
}

class Program
{
    static void Main()
    {
        CustomConverter overload = new CustomConverter();

        string intS = "123";
        overload.Converty(intS, out int intV);
        Console.WriteLine($"{intV}");

        string doubleS = "123,45";
        overload.Converty(doubleS, out double doubleV);
        Console.WriteLine($"{doubleV}");

        string boolS = "true";
        overload.Converty(boolS, out bool boolV, out int intV2);
        Console.WriteLine($"{boolS} — {boolV} — {intV2}");
    }
}
