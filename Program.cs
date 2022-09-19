Console.WriteLine("Введите число длину массива : = " );
int lenght = Convert.ToInt32(Console.ReadLine());
int i = 1;
int random = new Random(). Next(1,100);
int[] Array = new int[lenght];
for (i=1;i<Array[lenght];i++)
{
    Array[i]= random;
}
Console.WriteLine(Array[i]);