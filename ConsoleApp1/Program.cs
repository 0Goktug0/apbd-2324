static double CalculateAverage(int[] numbers)
{
    double sum = 0.0;
    foreach (var num in numbers) 
    {
        sum += num; 
    }

    return sum / numbers.Length;
}

int[] numbers = { 40, 82, 96, 50 };
double average = CalculateAverage(numbers);
Console.WriteLine(average);