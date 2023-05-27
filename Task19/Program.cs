// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
// 23432 -> да

int Promp(string message)                         //Метод печатает сообщение, для получения целого числа
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int Rank(int number1)                             //Метод определяет количество знаков в числе
{
    if (number1 < 0) number1 = -number1;
    int rank = 0;
    while (number1 >= 10)
        {
            number1 = number1 / 10;
            rank = rank + 1;
        };
    rank = rank + 1;
    return rank;
}
string Palindrome(int number)                      //Метод определяет является ли любое целое число палиндромом
{   int ranknumber = Rank(number);
    if (number < 0) number = -number;
        int numbercut = number;
        int assembly = 0;
        double y = Math.Pow(10, ranknumber - 1);
        int i = (int)y;
        while (i >= 1)
        {
            assembly = assembly + (numbercut % 10) * i;
            i = i / 10;
            numbercut = numbercut / 10;
        };
        if (number == assembly) return "Да, число является палиндромом";
        else
        {
            return "Нет, число не является палиндромом";
        }
};

int digit = Promp("Введите ЛЮБОЕ целое число, для проверки, является ли это число палиндромом: ");
string mes = Palindrome(digit);
Console.WriteLine(mes);