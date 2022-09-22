// Задача 17 Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//  и выдаёт номер четверти плоскости, в которой находится эта точка.
// 1. = -x и y
// 2. = x и Y
// 3. = -x и -Y
// 4. = x и -Y  

Console.WriteLine("Введите число num1 : = " );
Console.WriteLine("Введите число num2 : = " );
int x = Convert.ToInt16(Console.ReadLine());
int y = Convert.ToInt16(Console.ReadLine());
Boolean X=true;
Boolean Y=true;
X = x>0;
Y = y>0;
if(!X&Y)
Console.WriteLine("Первая плоскость");
if(X&Y)
Console.WriteLine("Вторая плоскость");
if(!X&!Y)
Console.WriteLine("Третья плоскость");
if(X&!Y)
Console.WriteLine("Четвертая плоскость");
if (x==0|y==0){
    Console.WriteLine("X или Y равен нулю");
}

