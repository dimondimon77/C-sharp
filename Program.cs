// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число 1 : = " );
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число 2 : = " );
int num2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число 3 : = " );
int num3 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число 4 : = " );
int num4 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число 5 : = " );
int num5 = Convert.ToInt16(Console.ReadLine());
int[] massiv = new int[]{num1,num2,num3,num4,num5};
int M = 0;
for(int i = 0;i<massiv.Length;i++){
    if(massiv[i]>0){
        M++;
    }
}
Console.WriteLine("Количество чисел больше нуля = " + M);