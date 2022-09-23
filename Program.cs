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
int ten2 = 1;
int i = 0;
for(; i < massiv.Length;i++)
{
    ten = ten * 10;
    massiv[i] = num%ten;
    massiv[i] = massiv[i]/ten2;
    ten2 = ten2 * 10;
    // Console.WriteLine(ten);
    // Console.WriteLine(num);
    // ten2 = ten2 * 10;
    // massiv[i] = num/ten2;
    // Console.WriteLine(massiv[i]);
    // Console.WriteLine(num);
}
    if(massiv[0] == massiv[4] & massiv[1] == massiv[3])
    {
    Console.WriteLine("Число явялется палиндромом");
    }
    else
    {
    Console.WriteLine("Число не явялется палиндромом");  
    }
