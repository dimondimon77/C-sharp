// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();
int Lenght0 = new Random().Next(3,10);
int Lenght1 = new Random().Next(3,10);
int[,] massiv = new int[Lenght0, Lenght1];
int sum = 0;
void RandomMassiv(int[,] array)
{
    int diagonal = 0;
    for (int i = 0; i < Lenght0; i++,diagonal++)
    {
        for (int j = 0; j < Lenght1; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
        sum += array[diagonal,diagonal];
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
Console.Write(sum);

