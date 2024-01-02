using System.ComponentModel;
using System.Globalization;


//namespace Plugins;

public class MathPlugin
{
    [KernelFunction, Description("Take the square root of a number")]
    public string Sqrt(string input)
    {
        return Math.Sqrt(Convert.ToDouble(input, CultureInfo.InvariantCulture)).ToString(CultureInfo.InvariantCulture);
    }

    // [KernelFunction, Description("Add two numbers")]
    // [SKParameter("input", "The first number to add")]
    // [SKParameter("number2", "The second number to add")]
    // public string Add(SKContext context)
    // {
    //     return (
    //         Convert.ToDouble(context["input"], CultureInfo.InvariantCulture) +
    //         Convert.ToDouble(context["number2"], CultureInfo.InvariantCulture)
    //     ).ToString(CultureInfo.InvariantCulture);
    // }

    [KernelFunction, Description("Add two numbers")]
    public string Add(  [Description("The first number to add")] int input,
                        [Description("The second number to add")] int number2)
    {
        return  (   Convert.ToDouble(input,CultureInfo.InvariantCulture) + 
                    Convert.ToDouble(number2, CultureInfo.InvariantCulture)
                 ).ToString(CultureInfo.InvariantCulture);
    }

    [KernelFunction, Description("Subtract two numbers")]
    public string Subtract( [Description("The first number to subtract")] int input,
                            [Description("The second number to subtract")] int number2)
    {
        return  (   Convert.ToDouble(input,CultureInfo.InvariantCulture) - 
                    Convert.ToDouble(number2, CultureInfo.InvariantCulture)
                 ).ToString(CultureInfo.InvariantCulture);
    }

    [KernelFunction, Description("Multiply two numbers. When increasing by a percentage, don't forget to add 1 to the percentage.")]    
    public string Multiply( [Description("The first number to multiply")] int input,
                            [Description("The second number to multiply")] int number2)
    {
        return  (   Convert.ToDouble(input,CultureInfo.InvariantCulture) * 
                    Convert.ToDouble(number2, CultureInfo.InvariantCulture)
                 ).ToString(CultureInfo.InvariantCulture);
    }

    [KernelFunction, Description("Divide two numbers")]    
    public string Divide( [Description("The first number to divide from")] int input,
                          [Description("The second number to divide by")] int number2)
    {
        return  (   Convert.ToDouble(input,CultureInfo.InvariantCulture) / 
                    Convert.ToDouble(number2, CultureInfo.InvariantCulture)
                 ).ToString(CultureInfo.InvariantCulture);
    }
}