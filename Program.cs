// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Введите позицию элемента");
int position = Convert.ToInt32(Console.ReadLine());
int Lenght0 = new Random().Next(4,10);
int Lenght1 = new Random().Next(4,10);
int[,] massiv = new int[Lenght0, Lenght1];
void RandomMassiv(int[,] array)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(9,62);
        }
    }
}
void ScanPosition(int[,] scan, int position)
{
    int count = 0;
        for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++, count++)
        {
           if(count == position)
           {
            Console.WriteLine($"Позиция элемента({position}) = {scan[i, j-1]}");
            return;
           }
        }
    }
    if(position > count)
    {
        Console.WriteLine($"Позиция элемента({position}) = Такого эелемента нет в массиве");
        return;
    }
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
}
RandomMassiv(massiv);
PrintMassiv(massiv);
ScanPosition(massiv,position);

