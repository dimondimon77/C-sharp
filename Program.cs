// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] massiv = new int[4, 4];
int count = 0;
void FillArray(int[,] fill, int x, int y, int fillX, int fillY)
{
            if (fillX > 0)
            {
                for (int i = 0; i < fillX; i++,count++)
                {
                    fill[i, y - 1] = count;
                }
            }
            if (fillY > 0)
            {
                for (int i = 0; i < fillY; i++)
                {
                    count ++;
                    fill[x - 1, i] = count ;
                }
            }
            if (fillX < 0)
            {
                for (int i = Math.Abs(fillX); i > 0; i--,count++)
                {
                    fill[i, y - 1] = count;
                }
            }
            if (fillY < 0)
            {
                for (int i = Math.Abs(fillY); i > 0; i--,count++)
                {
                    fill[x - 1,i - 1] = count;
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
FillArray(massiv, 1, 0, 0, 4);
FillArray(massiv, 0, 4, 4, 0);
FillArray(massiv, 4, 4, 0, -4);
FillArray(massiv, 4, 1, -2, 0);
FillArray(massiv, 2, 1, 0, 3);
FillArray(massiv, 3, 4, 1, 0);
PrintMassiv(massiv);
Console.WriteLine(count);


