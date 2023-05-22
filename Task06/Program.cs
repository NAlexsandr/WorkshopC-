// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Программа, которая на вход принимает число и выдаёт, является ли число чётным!");
Console.WriteLine("Начали ...");
Console.WriteLine("Введите Число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = number % 2;
if (remainder == 0)
    Console.WriteLine("Да, число четное");
else
{
    Console.WriteLine("Нет, число не является четным ");
}
