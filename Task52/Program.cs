// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Создаем двухмерный массив: ");                   // Программа   
int[,] arr = CreateMatrixRndInt(5, 6, 1, 10);
PrintMatrix(arr);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое по столбцам: ");
double[] AvCol = AverageColums(arr);

PrintArrayDouble(AvCol, 2);

double[] AverageColums(int[,] array)                                 // Считает среднее арифметическое столбцов двухмерного массива
{
    double[] ColAverage = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)    // Фиксируем столбец               
    {
        for (int j = 0; j < array.GetLength(0); j++) // Пробегаем по всем строкам внутри столбца
        {
            ColAverage[i] = ColAverage[i] + array[j, i]; // Суммируем все элементы внутри заданного стобца
        }
        ColAverage[i] = ColAverage[i] / array.GetLength(0); // Вычисляем среднее арифметическое элементов отдельно взятого столбца
    }
    return ColAverage;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Заполнение двумерного массива случайными целыми числами
{
    //                        0      1      
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintArrayDouble(double[] arr, int round)                 // Метод выводит на экран значения массива вещественных чисел с заданным округление 
{
    double temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        temp = Math.Round(arr[i], round);
        Console.Write($"{temp, 6}");                      
    }
}

void PrintMatrix(int[,] matrix)                                 // Вывод на экран двухмерного массива 
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