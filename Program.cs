// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

Console.Clear();
int num = new Random().Next(3,62);
int temp = 0;
int result = 0;
int ostatok = 0;
temp = num/2;
for(int i = 0;i<temp;i++){
ostatok = (num/2)%2;
result += ostatok;
}