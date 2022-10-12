// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int Lenght0 = new Random().Next(3, 10);
int Lenght1 = new Random().Next(3, 10);
int[,] massiv1 = new int[Lenght0, Lenght1];
int[,] massiv2 = new int[Lenght0, Lenght1];
 int[,] matrixMultiply = new int[massiv1.GetLength(0),massiv1.GetLength(1)];
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
void MultiplyMatrix(int[,] array1, int [,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
        matrixMultiply[i,j] = array1[i,j] * array2[i,j];
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
RandomMassiv(massiv1);
RandomMassiv(massiv2);
MultiplyMatrix(massiv1,massiv2);
PrintMassiv(massiv1);
PrintMassiv(massiv2);
PrintMassiv(matrixMultiply);


