static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

int[] numbers = { 5, 6, 7, 8 };
double average = GetAverage(numbers);
Console.WriteLine(average);