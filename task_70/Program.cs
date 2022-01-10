// Найти сумму цифр числа
//если чиcло меньше 99, делим его на 10 с остатком
Console.WriteLine("Hello, World!");

int Sum (int a);
{
    int a = int.Parse(Console.ReadLine());
    int sum = (a % 10 + a /10);

    if (a < 100) return sum ;
else return Sum;
Console.WriteLine(sum);
}

//int a = int.Parse(Console.ReadLine());

Sum (a);
//int sum = 0;



