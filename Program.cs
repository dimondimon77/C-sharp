// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Введите число N : = " );
int N = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[N+1];
for(int i = 1, sum = 1;i<N+1;i++){
    sum *= i;
    massiv[i] = sum;
    Console.WriteLine(massiv[i]);
}

