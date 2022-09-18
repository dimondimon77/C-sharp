Console.WriteLine("Введите число N : = " );
int N = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[N];
int index = 0;
int Value = 1;
    for(; index < N;index++,Value++)
{
    massiv[index] = Value;
    if ((massiv[index] % 2) == 0)
    {
    Console.WriteLine(massiv[index]);
    }
}



