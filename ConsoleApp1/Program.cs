static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

int[] numbers = { 9, 10, 11, 12 };
double average = GetAverage(numbers);
Console.WriteLine(average);