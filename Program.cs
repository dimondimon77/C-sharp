Console.WriteLine("Введите число num1 : = " );
Console.WriteLine("Введите число num2 : = " );
Console.WriteLine("Введите число num3 : = " );
Console.WriteLine("Введите число num4 : = " );
Console.WriteLine("Введите число num5 : = " );
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
int num3 = Convert.ToInt16(Console.ReadLine());
int num4 = Convert.ToInt16(Console.ReadLine());
int num5 = Convert.ToInt16(Console.ReadLine());
int[] nums = {num1,num2,num3,num4,num5};
int index = 0;
int max = 0;
for (;index < nums.Length;index++)
{
    if(max<nums[index])
    {
        max = nums[index];
    }
}
Console.WriteLine("Максисмальное число =" + max);


