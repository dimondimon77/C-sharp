// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int random = new Random().Next(1,11);
int[] massiv = new int[8];
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


