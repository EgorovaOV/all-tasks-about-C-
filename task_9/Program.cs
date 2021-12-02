// Показать последнюю цифру трёхзначного числа

Console.WriteLine("enter number");

int num = int.Parse(Console.ReadLine());

if (num <= 999 & num > 99)
{
    Console.WriteLine("Third digit of nunber is");
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("Number is not three digit");
}
