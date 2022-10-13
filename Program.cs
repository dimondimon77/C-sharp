// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Find1(int begin, int target, int count)
{
    if (begin == target) return begin;
    else {Console.Write($"{count} "); return Find1(begin + 1, target,count + 1);}
}
Console.WriteLine(Find1(1,10,1));

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int Find2(int begin, int target)
{
    if (begin == target) return begin;
    else {Console.Write($"{begin} "); return Find2(begin + 1, target);}
}

Console.WriteLine(Find2(9,12));

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Find3(int num)
{
    if (num < 10) return num;
    else return num = Find3(num % 10) + Find3(num / 10);
}
Console.WriteLine(Find3(55));

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Find4(int A, int B)
{
    if (B == 1) return A;
    else return A * Find4(A, B - 1);
}
Console.WriteLine(Find4(2, 10));