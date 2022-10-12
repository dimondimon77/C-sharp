// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int Lenght0 = new Random().Next(4, 6);
int Lenght1 = new Random().Next(5, 8);
int[,] massiv = new int[Lenght0, Lenght1];
void RandomMassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void SumLine(int[,] sumMassiv)  // Функция которая складывает сумму каждой строки, а затем кладет результат в массив. 
                                // Далее значения в новом массиве сравниваются между собой и вычисляется меньшая сумма
{
    int sum = 0;
    int min = 0;
    int indexMin = 0;
    int[] compare = new int[sumMassiv.GetLength(0)];
    for (int i = 0; i < sumMassiv.GetLength(0); i++)
    {
        for (int j = 0; j < sumMassiv.GetLength(1); j++)
        {
        sum += sumMassiv[i,j];
        }
        compare[i] = sum;
        sum = 0;
    }
    min = compare[0];
    for (int k = 0; k < compare.Length; k++)
    {
        Console.WriteLine(compare[k]);
        if (compare[k] < min)
        {
            min = compare[k];
            indexMin = k;
        }
    }
    Console.WriteLine($"Сумма элементов наименьшой строки = {min}, это строка под номером ({indexMin + 1})");
}
void PrintMassiv(int[,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
            Console.Write($"{print[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
RandomMassiv(massiv);
PrintMassiv(massiv);
SumLine(massiv);



