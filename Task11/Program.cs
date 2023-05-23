// See https://aka.ms/new-console-template for more information

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка [100, 999] -> {number}");

int res = DeleteSecondDigit(number);
Console.WriteLine($"Итог -> {res}");

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;

    int result = firstDigit * 10 + lastDigit;
    return result;
}