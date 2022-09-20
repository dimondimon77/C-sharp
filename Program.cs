// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число : = " );
int num = Convert.ToInt32(Console.ReadLine());
int temp = 0;
int ten = 10;
int count = 0;
int countTarget = 3;
int result = 0;
temp = num;
if (num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else{
for(;temp>10;){
    temp = num/ten;
    ten=ten*10;
   Console.WriteLine(temp);
   Console.WriteLine(ten);
       if(temp<10){
        break;
        }
    }
while(count<countTarget)
{
    count++;
    temp = temp*ten;
    ten=ten/10;
    temp = num/ten;
    Console.WriteLine(ten);
    Console.WriteLine(temp);
    Console.WriteLine(count);
}
if (count==3)
{
    result = temp%100%10;
    Console.Clear();
    Console.WriteLine(num);
    Console.WriteLine("=" + result);
}
}
