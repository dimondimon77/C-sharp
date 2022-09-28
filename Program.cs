// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число : = " );
int num = Convert.ToInt32(Console.ReadLine());
int ten = 1;
int temp = 0;
int i = 0;
temp = num;
for(; i < temp;i++){
ten *= 10;    
temp /= ten;
}
int[] massiv = new int[i];
massiv[0]=temp;
for(i = 1;i<massiv.Length;i++){
    ten /= 10;
    temp *= ten;
    massiv[i] = temp;
    Console.WriteLine(temp);
Console.WriteLine("Результат = " + massiv[i]);
}



