// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Length = new Random().Next(4,10);
int[] massiv = new int[Length];
void RandomMassiv(int[] collect){
    int random = 0;
    for(int i = 0;i<collect.Length;i++){
        random = new Random().Next(1,999);
        collect[i] = random;
    }
}
void ScanParity(int[] scan){
    int count = 0;
    for(int i = 0;i<scan.Length;i++){
        int sum = num.Where(Char.IsDigit).Sum(c => c - '0');
    }
}
void MassivPrint(int[] print){
        for(int i = 0;i<print.Length;i++){
        Console.WriteLine(print[i]);
    }
}
RandomMassiv(massiv);
MassivPrint(massiv);
// Вариант без функций
// int random1 = new Random().Next(1,11);
// for(int i = 0;i<massiv.Length;i++){
//         random1 = new Random().Next(1,11);
//         massiv[i] = random1;
//         Console.WriteLine(massiv[i]);
//     }


