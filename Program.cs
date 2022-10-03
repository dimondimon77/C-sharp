
// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник 
// с сторонами такой длины.

// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше суммы двух других сторон.


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