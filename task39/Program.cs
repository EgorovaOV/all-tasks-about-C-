// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] array = { 1, 2, 3, 4, 5, 6, 7 };

int last = array.Length -1;

int first = 0;

int[] newarray = new int[array.Length / 2];

while (last > first)
{
    int newarrayindex = 0;
    newarray[newarrayindex] = array[last] * array[first];
    last--;
    first++;
    Console.WriteLine(newarray[newarrayindex]);
    newarrayindex++;
}




