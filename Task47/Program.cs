// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] array2d = CreateMatrixRndDouble(3, 4, -100, 100);              // Программа: Задает двумерный массив размером m×n, 
PrintMatrixDouble(array2d, 2);                                              //         заполненный случайными вещественными числами.




double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max) // Создание двумерного массива случайными вещественными числами
{
    //                        0      1      
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max + 1 - min) + min; // Вещественное число берется из интервала [min, max]
        }
    }
    return matrix;
}


void PrintMatrixDouble(double[,] matrix, int round)            // Вывод на экран двухмерного массива вещественных чисел, округленных до заданного разряда
{
    double temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = Math.Round(matrix[i, j], round);           // При выводе на экран число округляется до заданного разряда
            Console.Write($"{temp,10}");
        }
        Console.WriteLine();
    }
}

