string[] daysweek = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int index = 0;
Console.WriteLine("Введите число");
index = Convert.ToInt16(Console.ReadLine());
index = index - 1;
Console.WriteLine(daysweek[index]);