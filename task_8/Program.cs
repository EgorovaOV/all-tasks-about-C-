// Показать четные числа от 1 до N

Console.WriteLine("Enter number");

int n = int.Parse(Console.ReadLine());

int start = 1;

int even_n = (start+1);

while (even_n <= n)
{
    if (even_n % 2 == 0)
    {
        Console.WriteLine(even_n);
    }
    even_n = (even_n+2);
}
