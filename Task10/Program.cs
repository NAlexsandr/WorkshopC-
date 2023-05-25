// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int SecondNumber(int num)
    {
        int second = num / 10;
        second = second % 10;
        return second;
        
    }
    
Console.WriteLine("Ведите трехзначное число и получите на выходе ВТОРУЮ цифру чиcла: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
 Console.WriteLine($"Вторая цифра числа {SecondNumber(number)}");
 else
 {
    Console.WriteLine("Число введено некорректно");
 };


    