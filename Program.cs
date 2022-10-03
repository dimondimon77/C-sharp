// **Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]
Console.Clear();
int Length = new Random().Next(3,11);
int[] massiv = new int[Length];
int temp = A;
int i=1;
int[] massiv = new int[B+1];
for(; i < B;i++){
temp *= A;
massiv[i] = temp;
}
Console.WriteLine("Результат = " + massiv[B-1]);


