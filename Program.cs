// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Length = new Random().Next(4,10);
int[] massiv = new int[Length]; // Создаем массив, длина от 5 до 9
void RandomMassiv(int[] collect){
    int random = 0;
    for(int i = 0;i<collect.Length;i++){
        random = new Random().Next(100,999); //Создаем функцию которая заполняет массив, рандомными числами
        collect[i] = random;
    }
}
RandomMassiv(massiv);
string convert = String.Join("", massiv); // Тут переводим все цифры в одну строку
int count = 0;
for(int i = 0; i<convert.Length;i++){
   char scan = convert[i]; // В этом цикле проверяем каждый символ на четность
   if(scan%2==0){
    count++;  // Считаем количество четных цифр
   }
}
Console.WriteLine(convert); // Выводим строку
Console.WriteLine(count); // Выводим количество четных чисел