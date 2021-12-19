// Написать программу замену элементов массива на противоположные
double AntiFill (double [] ar)
{
    int i = 0;
    int index = ar.Length;
    while (i < index)
    {
        ar[i] = -ar[i];
        i++;
    }
    return ar [i];
    Console.WriteLine(ar[i]);
}
double array = { 1 , -2, 6 , -4, 8.2, 1};

AntiFill (array);

