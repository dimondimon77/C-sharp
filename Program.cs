// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число 1 : = " );
int b1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число 2 : = " );
int k1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число 3 : = " );
int b2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число 4 : = " );
int k2 = Convert.ToInt16(Console.ReadLine());
int x = 0;
Console.WriteLine($"y1 = {k1*x+b1}");
Console.WriteLine($"y2 = {k2*x+b2}");