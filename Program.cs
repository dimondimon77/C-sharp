// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] massiv = new int[,] {{1,1,1,1,1,1},
                            {1,0,0,0,0,1},
                            {1,0,0,0,0,1},
                            {1,0,0,0,0,1},
                            {1,0,0,0,0,1},
                            {1,1,1,1,1,1},};
int x = 0;
int count = 1;
void Fill(int row, int col)
{
    x++;
    count++;
    if(x==12){
    Fill(row-1, col);
    x--;
    }
    if(x<12 || x>12){
    if (massiv[row, col] == 0)
    {
        massiv[row, col] = x;
        Fill(row, col+1);
        if(massiv[row, col] != 0){
        x--;
        Fill(row+1, col); 
        }
        if(massiv[row, col] != 0){
        x--;
        Fill(row, col-1);
        }
        if(massiv[row, col] != 0){
        x--;
        Fill(row-1, col);
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
Fill(1, 1);
PrintMassiv(massiv);
Console.WriteLine(count);


