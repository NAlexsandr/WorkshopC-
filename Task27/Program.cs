// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int Promp(string message)                         //Метод печатает сообщение, для получения целого числа
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int SumOfDigit(int a)                            //Метод принимает на вход число и выдаёт сумму цифр в числе
{
    int sum = 0;
    int sumtemp = a;
    while (sumtemp >= 1)
    {
        sum = sum + sumtemp % 10;
        sumtemp = sumtemp / 10;
    }
 return sum;
}

int x = Promp("Введите число А : ");
int res = SumOfDigit(x);
Console.WriteLine($"Сумма цифр в числе = {res}");