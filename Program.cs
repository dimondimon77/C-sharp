// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int[,] massiv = new int[4, 4];
void FillArray(int[,] fill,int x,int y){
    if(x == 0 & y == 4){
    for (int i = 0; i < y; i++)
    {
        fill[x,i]= new Random().Next(10,100);
    }   
    }  
    if(x == 4 & y == 0){
    for (int i = 0; i < x; i++)
    {
        fill[i,fill.GetLength(1)-1]= new Random().Next(10,100);
    }   
    } 
    if (x==4 & y==4){
    for (int i = 0; i < y; i++)
    {
        fill[x-1,i]= new Random().Next(10,100);
    }  
    }
    
    // for (int i = 0; i < fill.GetLength(0); i++)
    // {
    // for (int j = 0; j < fill.GetLength(1); j++)
    // {
    //     fill[i,j]= new Random().Next(10,100);
    // }   
    // }
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
FillArray(massiv,0,4);
FillArray(massiv,4,0);
FillArray(massiv,4,4);
FillArray(massiv,4,0);
PrintMassiv(massiv);


