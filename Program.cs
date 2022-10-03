// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]
int Length = new Random().Next(3,11);
int[] massiv = new int[Length];
int obratka = 0;
void RandomMassiv(int[] collect){
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
void Obratka(int[] scan){
    obratka = scan.Length;
    int i = 0;
    for(;obratka<1;obratka--,i++){
        scan[obratka-i]=scan[i];
    }
}
RandomMassiv(massiv);
PrintMassiv(massiv);
Obratka(massiv);
PrintMassiv(massiv);