// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число : = " );
int num = Convert.ToInt32(Console.ReadLine());
int lenght = 1;
int temp = 0;
int ten = 10;
Boolean parity = true;
Boolean stop = true;
temp = num;
stop = temp>10;
parity = lenght%2 == 0;
for(;stop;){
for(;!parity;lenght++)
{
    parity = lenght%2 == 0;
    temp = num/ten;
    ten=ten*10;
    stop = temp>10;
    Console.WriteLine(temp);
    Console.WriteLine(ten);
    if(!stop){
        Console.WriteLine(temp);
        Console.WriteLine(lenght);
        break;
    }
}
for(;parity;lenght++)
{
    parity = lenght%2 == 0;
    temp = num/ten;
    ten=ten*10;
    stop = temp>10;
   Console.WriteLine(temp);
   Console.WriteLine(ten);
       if(!stop){
        Console.WriteLine(temp);
        Console.WriteLine(lenght);
        break;
        }
    }
}
int[] massiv = new int[lenght];
Console.WriteLine(massiv[7]);
