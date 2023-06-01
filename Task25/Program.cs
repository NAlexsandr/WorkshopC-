// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int Promp(string message)                         //Метод печатает сообщение, для получения целого числа
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int Exponentiate(int a, int b)                    // Метод принимает на вход два числа (A и B) и возводит число A в натуральную степень B
{
    int number = a;
    int result = a;
    for (int i = 2; i <= b; i++)
    {
        result = result*number;
    }
    return result;
}

int x = Promp ("Введите число, которое будете возводить в степень А :");
int y = Promp ("Введите степень числа B :");
int res = Exponentiate(x, y);
Console.WriteLine($"А в степени В = {res}");