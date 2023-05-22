
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (N < 0)
{ Console.WriteLine("Некорректно введено число "); }
if (N < 2 && N > 0)
{ Console.WriteLine("Нет ряда четных чисел "); }
while (i <= N)
{
    Console.Write($"{i}, ");
    i = i + 2;
}




