// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

Console.Clear();
int num = new Random().Next(10,15);
int temp = num; 
int count = 0;
int minus = 0;
int[] massiv = new int[40];
for(int i = 0,ostatok = 0;temp>0;i++,count++){
ostatok = temp%2;
temp /=2;
massiv[i] = ostatok;
}
Console.WriteLine(num);
minus = count;
for(int i = 0;i<count;i++,minus--){
    Console.Write(massiv[minus-1]);
}