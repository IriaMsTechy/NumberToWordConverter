// See https://aka.ms/new-console-template for more information

double amount = 0;
var text = string.Empty;
var myConverter = new NumberToWordConverter.Converter.NumberToWordConverter();
Console.WriteLine("Please, introduce the amount in pounds.");
var amountTxt = Console.ReadLine();

try
{
    amount = Convert.ToDouble(amountTxt.TrimStart('£'));
    text = myConverter.Converter(amount);
}
catch (Exception ex)
{
    text = "error in the parameters " + amountTxt + " may not be a number writen with digits.";
}
finally
{
    Console.WriteLine(text);
}