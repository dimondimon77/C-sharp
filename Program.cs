// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Clear();
Console.WriteLine("Введите число : = " );
int num = Convert.ToInt32(Console.ReadLine());
// int num = new Random().Next(1,99999);
int[] massiv = new int[5];
int ten = 1;
int i = 0;
for(; i < massiv.Length;i++)
{
    ten = ten * 10;
    massiv[i] = (num%ten)/(ten/10);
}
    if(massiv[0] == massiv[4] & massiv[1] == massiv[3])
    {
    Console.WriteLine("Число явялется палиндромом");
    }
    else
    {
    Console.WriteLine("Число не явялется палиндромом");  
    }
