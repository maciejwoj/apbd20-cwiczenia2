// See https://aka.ms/new-console-template for more information

static double GetAverage(int[] numbers)
{
    double sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);

static int GetMax(int[] numbers)
{
    int max = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
       if(numbers[i] > max)
       {
           max = numbers[i];
       } 
    }

    return max;
}

Console.WriteLine(GetMax(numbers));