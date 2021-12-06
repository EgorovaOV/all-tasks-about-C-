// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Enter day of week");

int day = int.Parse(Console.ReadLine());

if (day > 7 | day <= 0)
{
Console.WriteLine("you enter wrong day");
}
else if (day == 7)
{
  Console.WriteLine("it is sunday");
}
else if (day == 6)
{
  Console.WriteLine("it is saturday");
}
else Console.WriteLine("sorry");