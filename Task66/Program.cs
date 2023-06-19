// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// ПРОГРАММА
Console.WriteLine("Введите два натуральных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int summ = SumOfElementsFromMtoN(number1, number2);
Console.Write($"Cумма натуральных элементов в промежутке от M до N = {summ} ");

// Метод (рекурсивный) находит сумму натуральных элементов в промежутке от M до N
int SumOfElementsFromMtoN(int num1, int num2)
{
    int sum = 0;
    if (num1 == num2)
    {
        return num1;
    }
    else
    {
        if (num2 > num1)
        {
            sum = num1 + SumOfElementsFromMtoN(num1 + 1, num2);
        }
        if (num2 < num1)
        {
            sum = num2 + SumOfElementsFromMtoN(num2 + 1, num1);
        }
    }
    return sum;
}
