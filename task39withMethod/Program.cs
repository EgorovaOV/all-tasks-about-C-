// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
void Fill(int[] array, int[] newarray)
{
    int last = array.Length - 1;

    int first = 0;

    int index = 0;
    while (last > first)
    {
        newarray[index] = array[last] * array[first];
        last--;
        first++;
        index++;
    }

}

void Print(int[] col)
{
    int count = col.Length;
    int z = 0;
    while (z < count)
    {
        Console.WriteLine(col[z]);
        z++;
    }
    //for (int i = 0; i < col.Length; i++)
   // {
   //     Console.WriteLine(col[i]);
   // }
}

int[] some = { 1, 2, 3, 4, 5, 6, 7 };

int dlina = (some.Length / 2);

int[] someelse = new int [dlina];

Fill(some, someelse);

Print(some);
Console.WriteLine();
Print(someelse);
