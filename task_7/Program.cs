// Показать числа от -N до N

int n = int.Parse(Console.ReadLine());

int min = -n;

while (min <= n)
{
    Console.WriteLine(min);
    min = (min+1);
}

