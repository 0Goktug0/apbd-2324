static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

int[] numbers = { 13, 14, 15, 16 };
double average = GetAverage(numbers);
Console.WriteLine(average);