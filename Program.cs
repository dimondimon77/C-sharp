// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Length = new Random().Next(4,10);
int[] massiv = new int[Length];
void RandomMassiv(int[] collect){
    int random = 0;
    for(int i = 0;i<collect.Length;i++){
        random = new Random().Next(100,999);
        collect[i] = random;
    }
}
RandomMassiv(massiv);
string convert = String.Join("", massiv);
int count = 0;
for(int i = 0; i<convert.Length;i++){
   char scan = convert[i]; 
   if(scan%2==0){
    count++;
   }
}
Console.WriteLine(convert);
Console.WriteLine(count);