// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
int[,] massiv = new int[4,4];
void FillRight(int[,] fill,int x,int y, int step){
for (int i = 0;i<step && y < fill.GetLength(1); y++,i++)
        {
            fill[x,y] = 12;
        }
}
void FillLeft(int[,] fill,int x,int y, int step){
    for (int i = 0;i<step && y < fill.GetLength(1); y--,i++)
        {
            fill[x,y] = 14;
        }
    
}
void FillDown(int[,] fill,int x,int y, int step){
for (int i = 0;i<step && x < fill.GetLength(0); x++,i++)
        {
            fill[x,y] = 12;
        }
}
void FillUp(int[,] fill,int x,int y, int step){
   for (int i = 0;i<step && x < fill.GetLength(0); x--,i++)
        {
            fill[x,y] = 6;
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
FillRight(massiv,0,0,4);
FillDown(massiv,0,3,3);
FillLeft(massiv,3,3,4);
FillUp(massiv,2,0,2);
FillRight(massiv,1,1,2);
FillDown(massiv,2,2,1);
FillLeft(massiv,2,1,1);
PrintMassiv(massiv);
// Вариант решения через рекурсию
// Console.Clear();
// int[,] massiv = new int[,] {{1,1,1,1,1,1},
//                             {1,0,0,0,0,1},
//                             {1,0,0,0,0,1},
//                             {1,0,0,0,0,1},
//                             {1,0,0,0,0,1},
//                             {1,1,1,1,1,1},};
// int x = 0;
// void Fill(int row, int col)
// {
//     x++;
//     if (x == 12)
//     {
//         Fill(row - 1, col);
//         massiv[2, 1] = 12;
//     }
//     if (massiv[row, col] == 0)
//     {
//         massiv[row, col] = x;
//         Fill(row, col + 1);
//         if (massiv[row, col] != 0)
//         {
//             x--;
//             Fill(row + 1, col);
//         }
//         if (massiv[row, col] != 0)
//         {
//             x--;
//             Fill(row, col - 1);
//         }
//         if (massiv[row, col] != 0)
//         {
//             x--;
//             Fill(row - 1, col);
//         }
//     }
// }

// void PrintMassiv(int[,] print)
// {
//     for (int i = 1; i < print.GetLength(0) - 1; i++)
//     {
//         for (int j = 1; j < print.GetLength(1) - 1; j++)
//         {
//             Console.Write($"{print[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// Fill(1, 1);
// PrintMassiv(massiv);


