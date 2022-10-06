// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Clear();
int Lenght0 = new Random().Next(3,10);
int Lenght1 = new Random().Next(3,10);
int[,] massiv = new int[Lenght0, Lenght1];
void RandomMassiv(int[,] array)
{
    for (int i = 0; i < Lenght0; i++)
    {
        for (int j = 0; j < Lenght1; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
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

