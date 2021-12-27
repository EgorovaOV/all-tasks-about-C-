// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

int b = 2, bb = 3, k = 4, kk = 6;

void InterPoint (double k1, double b1, double k2, double b2)
{
double a = double.Parse(Console.ReadLine());
double aa = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double bb = double.Parse(Console.ReadLine());

double x = (aa / a);
double y = (bb /b);
Console.WriteLine(x);
Console.WriteLine(y);
if (x == y)
{
    Console.WriteLine("Straights are same ");
}

else Console.WriteLine($"Straights intersect when X equal {((bb-b)/(a-aa))}");
 
}


InterPoint (b, bb,k, kk);


