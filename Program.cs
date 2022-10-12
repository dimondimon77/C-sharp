// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int Lenght0 = new Random().Next(3, 10);
int Lenght1 = new Random().Next(3, 10);
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
void SortedMassiv(int[,] sort)
{
    for (int i = 0; i < sort.GetLength(0); i++)
    {
        for (int j = 0,temp = 0; j < sort.GetLength(1); j++)
        {
            if (sort[i,j] < sort[i,j + 1]) {
                temp = sort[i,j];
                sort[i,j] = sort[i,j + 1];
                sort[i,j + 1] = temp;
            if(j==sort.GetLength(1)-2) return;
        }
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
    Console.WriteLine();
}
RandomMassiv(massiv);
PrintMassiv(massiv);
SortedMassiv(massiv);
PrintMassiv(massiv);


