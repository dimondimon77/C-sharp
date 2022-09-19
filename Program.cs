Console.WriteLine("Введите число number : = " );
int number = Convert.ToInt16(Console.ReadLine());
int num1 = 7;
int num2 = 23;
Boolean comparison1 = true;
Boolean comparison2 = true;
comparison1 = number%num1 == 0;
comparison2 = number%num2 == 0;
if(comparison1&comparison2)
{
    Console.WriteLine("Успех");
}
if(!(comparison1&comparison2))
{
    Console.WriteLine("Не вышло");
}
