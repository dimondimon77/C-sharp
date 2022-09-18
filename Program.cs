Console.WriteLine("Введите число num1 : = " );
Console.WriteLine("Введите число num2 : = " );
Console.WriteLine("Введите число num3 : = " );
int num1 = Convert.ToInt16(Console.ReadLine());
int num2 = Convert.ToInt16(Console.ReadLine());
int num3 = Convert.ToInt16(Console.ReadLine());
int[] nums = {num1,num2,num3};
int index = 0;
int max = 0;
for (;index < nums.Length;index++)
{
    if(nums[0]>nums[1]){
        max = nums[0];
    }
    if(max<nums[index])
    {
        max = nums[index];
    }
        
}
Console.WriteLine("Максисмальное число =" + max);


