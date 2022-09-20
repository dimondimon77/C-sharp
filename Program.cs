// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N : = " );
int N = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[N];
int index = 0;
int Value = 1;
    for(; index < N;index++,Value++)
{
    massiv[index] = Value;
    if ((massiv[index] % 2) == 0)
    {
    Console.WriteLine(massiv[index]);
    }
}



