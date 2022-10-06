// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
            if(i % 2 == 0 && j % 2 == 0)
            {
            array[i, j] = array[i, j] * array[i, j];
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
}
RandomMassiv(massiv);
PrintMassiv(massiv);

