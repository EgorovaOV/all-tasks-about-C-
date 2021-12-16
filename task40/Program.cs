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
    for (int index = 0; index < array.Length; index++ )  
    {
        double max = array[0];
        double min = array [0];
        if (array [index] > max)
        {
            max = array[index];
        }
        else if (array[index] < max)
        {
            min = array[index];
        }
        return max;
        return min;
        }

}

double [] col = new double [10];

Fill (col);

Print (col);

Diff (col); 