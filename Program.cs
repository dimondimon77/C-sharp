Console.WriteLine("Введите число num1 : = " );
int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите число num2 : = " );
int num2 = Convert.ToInt16(Console.ReadLine());
Boolean briefly = true;
briefly = num2%num1 == 0;
int result = 0;
if(briefly)
{
    Console.WriteLine("Второе число кратно первому");
}
if(!briefly)
{
    Console.WriteLine("Второе число не кратно первому");
    result = num1%num2;
    Console.WriteLine("Остаток от деления =" + result);
}
