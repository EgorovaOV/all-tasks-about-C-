// По заданному номеру дня недели вывести его название

Console.WriteLine("Enter day of week");

int day = int.Parse(Console.ReadLine());

if (day == 1)
{
    Console.WriteLine("It is monday");
}
else if (day ==2)
{
    Console.WriteLine("It is theusday");
}
else if (day ==3)
{
    Console.WriteLine("It is wednesday");
}
else if (day ==4)
{
    Console.WriteLine("It is thuesday");
}
else if (day ==5)
{
    Console.WriteLine("It is friday");
}
else if (day ==6)
{
    Console.WriteLine("It is saturday");
}
else if (day ==7)
{
    Console.WriteLine("It is sunday");
}