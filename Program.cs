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
int[,] massiv = new int[3, 4];
int[,] massiv2 = new int[3, 4];
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            massiv[i, j] = massiv[i, j] * massiv2[i, j];
            Console.WriteLine(massiv[i,j]);
        }
    }
}


