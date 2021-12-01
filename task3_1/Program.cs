// По заданному номеру дня недели вывести его название

string [] week = {"","mon", "thues", "wedn", "thurs", "fri", "sat", "sun"};

Console.WriteLine("Enter day of week");

int day = int.Parse(Console.ReadLine());

Console.WriteLine(week [day]);
