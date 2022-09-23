// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите число A1 : = " );
Console.WriteLine("Введите число A2 : = " );
Console.WriteLine("Введите число A3 : = " );
Console.WriteLine("Введите число B1 : = " );
Console.WriteLine("Введите число B2 : = " );
Console.WriteLine("Введите число B3 : = " );
double A1 = Convert.ToDouble(Console.ReadLine());
double A2 = Convert.ToDouble(Console.ReadLine());
double A3 = Convert.ToDouble(Console.ReadLine());
double B1 = Convert.ToDouble(Console.ReadLine());
double B2 = Convert.ToDouble(Console.ReadLine());
double B3 = Convert.ToDouble(Console.ReadLine());
double[] massivA = new double[] {A1, A2, A3};
double[] massivB = new double[] {B1, B2, B3};
double d = 0;
double sum=0;
for(int i = 0; i < massivA.Length;i++)
{
    d = massivB[i] - massivA[i];
    d = Math.Pow(d,2);
    sum = sum + d;
}
Console.WriteLine(Math.Sqrt(sum));




