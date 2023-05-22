// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Программа сравнит два введенных Вами числа и напишет большее число");
Console.WriteLine("Начали ...");
Console.WriteLine("Введите Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
    Console.WriteLine($"Большее число из введенных {number1} ");
else
{
    Console.WriteLine($"Большее число из введенных {number2} ");
}