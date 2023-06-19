// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//функция ack(n, m)
//   если n = 0
//     вернуть m + 1
//   иначе, если m = 0
//     вернуть ack (n - 1, 1)
//   еще
//     вернуть ack(n - 1, ack (n, m - 1))

// ПРОГРАММА
Console.WriteLine("Введите два натуральных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int ack = AkkermanFunction(number1, number2);
Console.Write($"Значение функции Аккермана = {ack} ");

// Метод (рекурсивный) вычисление функции Аккермана
int AkkermanFunction(int n, int m)
{
    int k = 0;
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if (m == 0)
        {
            k = AkkermanFunction(n - 1, 1);
            return k;
        }
        else
        {
            k = AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
            return k;
        }
    }
}

