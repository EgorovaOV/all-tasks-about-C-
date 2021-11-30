// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Enter numA fnd numB");

int numA = int.Parse(Console.ReadLine());

int numB = int.Parse(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine("Larger number is");
    Console.WriteLine(numA);
    Console.WriteLine("Smaller naber is");
    Console.WriteLine(numB);
}
else if (numA < numB)
{
    Console.WriteLine("Larger number is");
    Console.WriteLine(numB);
    Console.WriteLine("Smaller naber is");
    Console.WriteLine(numA);
}
else
{
     Console.WriteLine("the numbers match");
}