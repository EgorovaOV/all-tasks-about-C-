// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void Fill(double[] array)
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        array[index] = new Random().Next(-10, 10);
        index++;
    }
}

void Print(double[] col)
{
    int count = col.Length;
    int index = 0;
    while (index < count)
    {
        Console.WriteLine(col[index]);
        index++;
    }
}
double Diff(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
        else if (array[index] < min)
        {
            min = array[index];
        }
        else max = min;
        diff = (max - min);
    }
    Console.WriteLine($"max is {max}");
    Console.WriteLine($"min is {min}");
    Console.WriteLine($"difference is {diff}");
    return diff;
    }

    double[] col = new double[5];

    Fill(col);

    Print(col);

    double difference = Diff(col);
    
