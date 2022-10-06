// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.Clear();
void RandomMassiv(){
int Length0 = new Random().Next(3,11);
int Length1 = new Random().Next(3,11);
    int[,] massiv = new int[Length0,Length1];
    int random = 0;
    for(int i = 0;i<massiv.GetLength(0);i++){
        random = new Random().Next(1,101);
        massiv[i] = random;
         for(int j = 0;j<massiv.GetLength(1);j++){
        random = new Random().Next(1,101);
        massiv[j] = random;
    }      
    }
}
RandomMassiv();







void PrintMassiv(int[] print){
    for(int i = 0; i<print.Length;i++){
        Console.WriteLine(print[i]);
    }
}
void SumBetweenMinMax(int[] scan){
    min = scan[0];
    max = scan[0];
    for(int i = 0;i<scan.Length;i++){
        if(scan[i]<min){
            min = scan[i];
        }
        if(scan[i]>max){
            max = scan[i];
        }
        sum = max - min;
    }
}
RandomMassiv(massiv);
PrintMassiv(massiv);
SumBetweenMinMax(massiv);
Console.WriteLine($"Разница между min и max = {max} - {min} = {sum} " );