// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число num : = " );
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int ten = 1;
for(int count = 0;temp>10;){
    ten *=10;
    temp = num/ten;
    count++;
    Console.WriteLine(count + 1);
}

