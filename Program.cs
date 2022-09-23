// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();
// Console.WriteLine("Введите число : = " );
// int num = Convert.ToInt32(Console.ReadLine());
int num = new Random().Next(1,99999);
int[] massiv = new int[5];
int ten = 1;
for(int i = 0; i < massiv.Length;i++)
{
    ten = ten * 10;
    massiv[i] = num%ten;
    Console.WriteLine(massiv[i]);
    Console.WriteLine(num);
}



