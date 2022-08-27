// Домашняя задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения для прямой линии 1:");
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения для прямой линии 2:");
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

if(k1!=k2)
{
    double oX = (b2 - b1)/(k1 - k2);
    double oY = k1 * oX + b1;
    Console.WriteLine($"Прямая y = {k1}*x + {b1} и прямая y = {k2}*x + {b2} пересекаются в точке с координатами ({Math.Round(oX,2)}; {Math.Round(oY,2)})");
}
else
{
    Console.WriteLine($"Прямая y = {k1}*x + {b1} и прямая y = {k2}*x + {b2} НЕ пересекаются");
}

