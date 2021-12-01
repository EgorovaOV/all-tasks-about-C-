// Найти максимальное из трех чисел

Console.WriteLine("Enter num1");

int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter num2");

int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter num3");

int num3 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("num1 is max");
    }
    else 
    {
       Console.WriteLine("num3 is max"); 
    }
}
else if (num2 > num3)
{
    Console.WriteLine("num2 is max");
}