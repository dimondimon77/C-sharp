// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int Lenght0 = new Random().Next(2,5);
int Lenght1 = new Random().Next(2,5);
int[,] massiv = new int[Lenght0, Lenght1];
void RandomMassiv(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(9,62);
        }
    }
}
void AverageSumColumn(int[,] avarageSum)
{
    double Sum = 0;
    for(int i = 0; i < avarageSum.GetLength(0);i++)
    {
        for (int j = 0; j < avarageSum.GetLength(1); j++)
        {
            Sum += avarageSum[j,i];
        }       
        Sum = Sum/avarageSum.GetLength(1); 
        Console.WriteLine($"Ср. Арифм. столбец ({i+1}) = {Sum}");
        Sum = 0;
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
AverageSumColumn(massiv);

