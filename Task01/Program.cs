// Написать программу, которая проверяет, является ли первое число квадратомм второго, числа вводит пользователь

Console.WriteLine("!!!Программа проверяет, является ли первое число квадратом второго!!!");
Console.WriteLine("Введите Первое целое число:");
int numberА = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе целое число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberА == numberB * numberB)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");
