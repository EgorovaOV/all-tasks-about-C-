// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Enter numA and numB");

int numA = int.Parse(Console.ReadLine());

int numB = int.Parse(Console.ReadLine());

if (numA / numB == numB)
{
    Console.WriteLine("numA is square of numB");
}
else 
{
    Console.WriteLine("numA is not square of numB");
}