static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);