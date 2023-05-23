// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Hello, World!");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Remain(num1, num2);
string printLine = result == 0 ? "Кратно" : $"не кратно, остаток {result}";
Console.WriteLine(printLine);

int Remain(int number1, int number2)
{
    int res = number1 % number2;

    return res;
}