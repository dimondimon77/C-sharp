// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число : = " );
int num = Convert.ToInt32(Console.ReadLine());
int lenght = 1;
int lenght2 = 0;
int temp = 0;
int temp2 =0;
int ten = 10;
int ten2 = 0;
int count = 0;
int countTarget = 3;
int result = 0;
temp = num;
for(;temp>10;){
    temp = num/ten;
    ten=ten*10;
   Console.WriteLine(temp);
   Console.WriteLine(ten);
       if(temp<10){
        lenght2 = lenght;
        ten2=ten;
        temp2 =temp;
        Console.WriteLine(temp);
        Console.WriteLine(temp2);
        Console.WriteLine(lenght);
        break;
        }
    }
while(count<countTarget)
{
    count++;
    temp2 = temp2*ten2;
    ten2=ten2/10;
    temp2 = num/ten2;
    Console.WriteLine(ten2);
    Console.WriteLine(temp2);
    Console.WriteLine(count);
}
if (count==3)
{
    result = temp2%100%10;
    Console.WriteLine(result);
}


