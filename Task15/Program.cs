// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
bool DayOfWeek(int num)
{
    if (num == 6 || num == 7)
        return true;
    else
    {
        return false;
    }
}
Console.WriteLine("Ведите любое ЦЕЛОЕ чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 7 || number < 1)
 Console.WriteLine("Число введено некорректно");
 else
 {
    if (DayOfWeek(number) == true) Console.Write("Да");
    else Console.Write("Нет");
 };
