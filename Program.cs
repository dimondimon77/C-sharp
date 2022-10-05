// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1 : = " );
int b1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число k1 : = " );
int k1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число b2 : = " );
int b2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число k2 : = " );
int k2 = Convert.ToInt16(Console.ReadLine());
double x = -10;
for(double y1 = 0, y2 = 0; x<10 ;){
    x += 0.1;
    y1=k1*x+b1;
    y2=k2*x+b2;
    if(y1==y2){
        Console.WriteLine($"Пересечение прямых достигнуто в точке = {y1} {y2}");
        break;
    }
}