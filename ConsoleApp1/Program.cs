static double GetAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}

int[] numbers = { 50, 55, 19, 59 };
double average = GetAverage(numbers);
Console.WriteLine(average);