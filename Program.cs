// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int[,,] matrix = new int[2, 2, 2];
void RandomMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        for (int k = 0; k < array.GetLength(2); k++)
        {
        array[i,j,k] = new Random((int)(DateTime.Now.Ticks)).Next(12, 56);  
        // генерация случайных чисел происходит по четкому математическому алгоритму.
        // эта переменная дается алгоритму для генерации, а посколько DateTime.Now.Ticks это 1/1000 секунды 
        // то это делает маловероятным тот факт что милисекунды двух генераций совпадут.
        }
        }
    }
}
void PrintMatrix(int[,,] print)
{
    for (int i = 0; i < print.GetLength(0); i++)
    {
        for (int j = 0; j < print.GetLength(1); j++)
        {
        for (int k = 0; k < print.GetLength(2); k++)
        {
        Console.Write($"{print[i,j,k]}({i}:{j}:{k}) ");
        }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
RandomMatrix(matrix);
PrintMatrix(matrix);


