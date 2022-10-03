
// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.

// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите число num1 : = " );
Console.WriteLine("Введите число num2 : = " );
Console.WriteLine("Введите число num3 : = " );
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
int num3 = Convert.ToInt16(Console.ReadLine());;
if(num1<=num2+num3){Console.WriteLine("Треугольник может существовать");}
else if(num2<=num1+num3){Console.WriteLine("Треугольник может существовать");}
else if(num3<=num1+num2){Console.WriteLine("Треугольник может существовать");}
else if(num1>num2+num3 & num2>num1+num3 & num3>num1+num2)
{Console.WriteLine("Треугольник не может существовать");}