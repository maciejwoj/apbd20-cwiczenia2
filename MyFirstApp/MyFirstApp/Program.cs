// See https://aka.ms/new-console-template for more information

Console.WriteLine("something change");
Console.WriteLine("change");
Console.WriteLine("third change");

static double GetAverage(int[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}