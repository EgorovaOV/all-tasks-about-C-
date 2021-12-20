// Написать программу замену элементов массива на противоположные
void AntiFill(int[] ar)
{
    int i = 0;
    int index = ar.Length;
    while (i < index)
    {
        ar[i] = -ar[i];
        Console.WriteLine(ar[i]);
        i++;
    }

}
int[] array = { 1, 2, 4, 8, 1 };

AntiFill(array);

