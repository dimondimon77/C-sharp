Console.WriteLine("Введите число");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array= new int[lenght];
for (int i = 0;i<lenght;i++)
{
    int x = new Random(). Next(1,1000);
    array[i] = x;
    Console.WriteLine(array[i]);
}
