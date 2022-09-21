// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();
int num = new Random().Next(1, 1000000);
int temp = 0;
int count = 0;
int countTarget = 3;
int result = 0;
temp = num;
if (num<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else{
void MassivLenght(int temp = 0,int ten = 10,int count = 0){
    temp = num;
for(;temp>10;){
    count++;
    temp = num/ten;
    ten=ten*10;
   Console.WriteLine(temp);
   Console.WriteLine(ten);
       if(temp<10){
        Console.WriteLine("count" + count);
        return;
        }
    }
}
MassivLenght(count);
{
    Console.WriteLine("count"+ count);
}
}
void Massiv(int[] massiv,int i = 0){
    for (;i<count;i++)
    {
        massiv[i]= temp;
    }

}
int[] massiv = new int[count];
Massiv(massiv);
{
    Console.WriteLine(massiv[2]);
}


// while(count<countTarget)
// {
//     count++;
//     temp = temp*ten;
//     ten=ten/10;
//     temp = num/ten;
//     Console.WriteLine(ten);
//     Console.WriteLine(temp);
//     Console.WriteLine(count);
// }
// if (count==3)
// {
//     result = temp%100%10;
//     Console.WriteLine(num);
//     Console.WriteLine("=" + result);
// }
// }
