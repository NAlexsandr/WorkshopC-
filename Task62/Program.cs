// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// ПРОГРАММА (решение рекурсивное): Спирально заполняет массив любой размерность K x K числами от 1 до KxK
int length = Promp("Введите размерность (любое целое число) массива K x K: ");
int[,] spiral = new int[length, length];
int counter = 1;
SpiralMatrix(0, 0, length, spiral);
if (length % 2 != 0)                                                       // Заполение послелнего элемента для массивов, где K нечетное число
{
    spiral[(length + 1) / 2 - 1, (length + 1) / 2 - 1] = length * length;
}
PrintMatrix(spiral);

// Метод: Спирально заполняет массив любой размерность K x K числами от 1 до KxK
void SpiralMatrix(int n, int m, int length, int[,] spiral)
{
    if (length > 1)
    {
        for (int i = 0; i < length; i++)
        {
            spiral[n, m + i] = counter;
            counter++;
        }
        counter = counter - 1;                      
        for (int i = 0; i < length; i++)
        {

            spiral[n + i, m + length - 1] = counter;
            counter++;
        }
        counter = counter - 1;                      
        for (int i = 0; i < length; i++)
        {
            spiral[n + length - 1, m + length - 1 - i] = counter;
            counter++;
        }
        counter = counter - 1;                      
        for (int i = 0; i < length - 1; i++)
        {

            spiral[n + length - 1 - i, m] = counter; 
            counter++;
        }
        SpiralMatrix(n + 1, m + 1, length - 2, spiral);
    }
    else return;

}

// Метод: Вывод на экран двухмерного массива 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}
// Метод печатает сообщение, для получения целого числа
int Promp(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}