// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Программа принимает на вход 3 числа и выдает Максимальное из них");
Console.WriteLine("Начали ...");
Console.WriteLine("Введите Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
    max = number2;
if (number3 > max)
    max = number3;
Console.WriteLine($"Максимальное из 3-х чисел: {max} ");