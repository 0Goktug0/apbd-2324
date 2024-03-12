static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

int[] numbers = { 10, 59, 68, 51 };
double average = GetAverage(numbers);
Console.WriteLine(average);