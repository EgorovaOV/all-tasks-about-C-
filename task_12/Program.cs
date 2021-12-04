// Выяснить, кратно ли число заданному, если нет, вывести остаток.

//Console.WriteLine("Enter number_A and number_B");

Console.WriteLine("Enter number_A");

int number_A = int.Parse(Console.ReadLine());

//int number_B = int.Parse(Console.ReadLine());
int number_B = 25;

if (number_A % number_B == 0)
{
    Console.WriteLine("number_A is multiple of number_B");
}

else if (number_B > number_A)
{
    Console.WriteLine("0");
}
else
{
    Console.WriteLine(number_A % number_B);
}