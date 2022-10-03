// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int Length = new Random().Next(3,11);
int[] massiv = new int[Length];
int sum = 0;
void RandomMassiv(int[] collect){ //Создаем функцию которая заполняет массив, рандомными числами
    int random = 0;
    for(int i = 0;i<collect.Length;i++){
        random = new Random().Next(1,101);
        collect[i] = random;
    }
}
void PrintMassiv(int[] print){
    for(int i = 0; i<print.Length;i++){
        Console.WriteLine(print[i]);
    }
}
void NonParitySum(int[] scan){
    for(int i = 0;i<scan.Length;i++){
        if(scan[i]%2==0){
        }
        else{
        sum += scan[i];
        }
    }
}
RandomMassiv(massiv);
PrintMassiv(massiv);
NonParitySum(massiv);
Console.WriteLine("Сумма нечетных чисел = " + sum);
// // BOUNUS
// // Программа которая выводит количество четных цифр во всем массиве
// int Length = new Random().Next(4,10);
// int[] massiv = new int[Length]; // Создаем массив, длина от 5 до 9
// void RandomMassiv(int[] collect){ //Создаем функцию которая заполняет массив, рандомными числами
//     int random = 0;
//     for(int i = 0;i<collect.Length;i++){
//         random = new Random().Next(100,999);
//         collect[i] = random;
//     }
// }
// RandomMassiv(massiv); // Используем функцию для созданного массива
// string convert = String.Join("", massiv); // Тут переводим все цифры в одну строку
// int count = 0;
// for(int i = 0; i<convert.Length;i++){
//    char scan = convert[i]; // В этом цикле проверяем каждый символ на четность
//    if(scan%2==0){
//     count++;  // Считаем количество четных цифр
//    }
// }
// Console.WriteLine(convert); // Выводим строку
// Console.WriteLine(count); // Выводим количество четных цифр