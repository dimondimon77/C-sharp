// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10

Console.WriteLine("Введите число A : = " );
int A = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[A];
    for(int index = 0,sum = 0,Value = 1; index < A;index++,Value++)
{
    sum +=Value;
    massiv[index] = sum;
    Console.WriteLine(massiv[index]);
}