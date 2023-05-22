// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = -number;
while (i <= number)
{
    Console.Write($"{i}, ");
    ++i;
}

