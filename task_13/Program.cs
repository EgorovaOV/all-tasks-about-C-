// Найти третью цифру числа или сообщить, что её нет

int number = int.Parse(Console.ReadLine());

int result = 0;

if (number > 999)
{
    result = (number / 10);
    while (result > 999)
    {
        result = (result / 10);
    }
    Console.WriteLine($"third digit of number is {result % 10}");
}
else if (number < 100)
{
    Console.WriteLine("there is no third digit of number");
}
else Console.WriteLine(number % 10);


