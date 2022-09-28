// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число A : = " );
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B : = " );
int B = Convert.ToInt32(Console.ReadLine());
//Вот основное правильное решение
Console.WriteLine("Результат = " + Math.Pow(A,B));
//Цикл
int temp = A;
int i=1;
int[] massiv = new int[B+1];
for(; i < B;i++){
temp *= A;
massiv[i] = temp;
}
Console.WriteLine("Результат = " + massiv[B-1]);


