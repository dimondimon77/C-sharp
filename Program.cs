// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int random = new Random().Next(1,11);
int[] massiv = new int[random];
void RandomMassiv(int[] collect){
    for(int i = 0;i<collect.Length;i++){
        collect[i]= random;
        random = new Random().Next(1,11);
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


