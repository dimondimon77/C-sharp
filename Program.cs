Console.WriteLine("Введите число num1 : = " );
Console.WriteLine("Введите число num2 : = " );
Console.WriteLine("Введите число num3 : = " );
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
int num3 = Convert.ToInt16(Console.ReadLine());
int max = 0;
if (num1>num2)
{
max = num1;
}
else
{
max = num2;
}
if (num3>num2)
{
max = num3;
}
Console.WriteLine("Максисмальное число =" + max);


