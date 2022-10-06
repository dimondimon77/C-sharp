// Необходимо найти  5 целых чисел (положительных), 
// которые будут удовлетворять такому условию
// x^5 + y^5 + z^5 + q^5 = w^5
// Т.е. сумма 4 чисел в пятой степени = 5 числу


int one = 1;
int two = 1;
int three = 1;
int four = 1;
int sum = 0;
for(int i = 0; i < 15;i++,one++,two++,three++,four++)
{
    one = one*one*one*one*one;
    two = two*two*two*two*two;
    three = three*three*three*three*three;
    four = four*four*four*four*four;
    sum = one + two + three + four; 
    Math.Sqrt(Math.Sqrt(Math.Sqrt(Math.Sqrt(Math.Sqrt(sum)))));
}
double proverka = 7776;
int stepen = 5;
double res = 0;
res = Math.Pow(proverka,-5);
Console.WriteLine(res);