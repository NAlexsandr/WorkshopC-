// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int ThreeNumber(int num)
{
    while (num >= 1000)
    {
        num = num / 10;
    }

    int three = num % 10;
    return three;
}

Console.WriteLine("Ведите любое ЦЕЛОЕ чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
    Console.WriteLine($"ТРЕТЬЯ цифра числа {ThreeNumber(number)}");
else
{
    Console.WriteLine("Третьей цифры нет");
};