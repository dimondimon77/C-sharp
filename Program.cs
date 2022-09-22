// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// 1. = -x и y
// 2. = x и Y
// 3. = -x и -Y
// 4. = x и -Y  
Console.Clear();
Console.WriteLine("Введите число num1 : = " );
Console.WriteLine("Введите число num2 : = " );
int x = Convert.ToInt16(Console.ReadLine());
int y = Convert.ToInt16(Console.ReadLine());
Boolean X=true;
Boolean Y=true;
X = x>0;
Y = y>0;
if(!X&Y)
Console.WriteLine("Первая плоскость (Возможные координаты: -32768 : 32767)");
if(X&Y)
Console.WriteLine("Вторая плоскость (Возможные координаты: 0 : 32768)");
if(!X&!Y)
Console.WriteLine("Третья плоскость (Возможные координаты: -32768 : 0)");
if(X&!Y)
Console.WriteLine("Четвертая плоскость (Возможные координаты: -32768 : 32767)");


