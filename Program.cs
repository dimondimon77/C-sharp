string[] daysweek = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int index = 0;
Console.WriteLine("Введите число");
index = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(daysweek[index]);