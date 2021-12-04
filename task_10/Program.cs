// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random (). Next (10, 99);

Console.WriteLine($"Your rabdom number is {number}");

int first = (number / 10);

int second = (number % 10);

if (first > second)
{
    Console.WriteLine($"Largest digit of number is {first}");
}
else if (first < second)
{
    Console.WriteLine($"Largest digit of number is {second}");
}
else 
{
    Console.WriteLine("Digits of number is same");
}