// Удалить вторую цифру трёхзначного числа

int number = new Random(). Next (100 , 999);

Console.WriteLine($"Your random namber is {number}");

int first = number / 100;

int third = number % 10;

int new_number = (first * 10 + third);

Console.WriteLine($"Your new namber is {new_number}");
