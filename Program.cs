// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();
int num = new Random().Next(1, 10000000);
int temp = 0;
int ten = 10;
int ten2 = 10;
int count = 0;
int countTarget = 3;
int result = 0;
int number = 0;
temp = num;
if (num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else{
for(;temp>10;){
    temp = num/ten;
    ten=ten*10;
//    Console.WriteLine(temp);
//    Console.WriteLine(ten);
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
    number = temp;
    number = number%ten2;
    Console.WriteLine(count + "-ая цифра =" +number);
    // if(count==1){
    //     number = number%ten2;
    // Console.WriteLine("Первая цифра числа :=" +number);
    // }
    // if(count==2){
    //     number = number%ten2;
    // Console.WriteLine("Вторая цифра числа :=" +number);
    // }
    // if(count==3){
    //     number = number%ten2;
    // Console.WriteLine("Третья цифра числа :=" +number);
    // }
    // Console.WriteLine(ten);
    // Console.WriteLine(temp);
    // Console.WriteLine(count);
    // Console.WriteLine(n);
}
if (count==countTarget)
{
    result = temp%100%10;
    Console.WriteLine(num);
    Console.WriteLine("Искомая цифра :=" + result);
}
}
