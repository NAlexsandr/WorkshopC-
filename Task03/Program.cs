// Написать программу, которая будет выдавать название Дня Недели по заданному ноимеру

Console.WriteLine("!!!Программа выдает название Дня Недели по заданному ноимеру от 1 до 7)!!!");
Console.WriteLine("Введите Целое число:");
int DayofWeek = Convert.ToInt32(Console.ReadLine());
if (DayofWeek > 7)
    Console.WriteLine("Ошибка. Неверный ввод. Введите целое число в диапазоне от 1 до 7");
if (DayofWeek < 1)
    Console.WriteLine("Ошибка. Неверный ввод. Введите целое число в диапазоне от 1 до 7");
if (DayofWeek == 1)
    Console.WriteLine("День недели: Понедельник");
if (DayofWeek == 2)
    Console.WriteLine("День недели: Вторник");
if (DayofWeek == 3)
    Console.WriteLine("День недели: Среда");
if (DayofWeek == 4)
    Console.WriteLine("День недели: Четверг");
if (DayofWeek == 5)
    Console.WriteLine("День недели: Пятница");
if (DayofWeek == 6)
    Console.WriteLine("День недели: Суббота");
if (DayofWeek == 7)
    Console.WriteLine("День недели: Воскресенье");
