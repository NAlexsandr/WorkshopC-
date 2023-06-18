// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// ПРОГРАММА
int[,] array2d = CreateMatrixRndInt(6, 5, 1, 10);  // Создаем двухмерный массив
PrintMatrix(array2d);
Console.WriteLine();
Console.WriteLine("Отсортированный массив по всем строкам Top-Down:");
SortRowsTopDownArray(array2d);                     // Сортируем Top-Down все строки двухмерного массива
PrintMatrix(array2d);


// Метод: Поиск МAX элемента в строке заданной длины (от столбца до столбца) в двухмерном массиве и установка MAX элемента
//        в начальный (firstcolums) столбец, который задан как начальный
void MaxELementFirstcolumsArray(int[,] array, int oneRows, int firstcolums)
{
    int max = array[oneRows, firstcolums];
    int indexMax = firstcolums;
    int j = firstcolums + 1;
    int temp = 0;
    while (j < array.GetLength(1))
    {
        if (array[oneRows, j] > max)
        {
            indexMax = j;
            max = array[oneRows, j];
        }
        j = j + 1;
    }
    temp = array[oneRows, firstcolums];
    array[oneRows, firstcolums] = array[oneRows, indexMax];
    array[oneRows, indexMax] = temp;
}

// Метод: Сортировка Top-Down ОДНОЙ заданной строки в двухмерном массиве с использованием Метода Поиска MAX элемента в строке
void SortOneRowsTopDownArray(int[,] array, int oneRows)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        MaxELementFirstcolumsArray(array, oneRows, j);
    }
}
// Метод: Сортировка Top-Down ВСЕХ строк в двухмерном массиве с использованием
// Метода Сортировка Top-Down ОДНОЙ заданной строки в двухмерном массиве
void SortRowsTopDownArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortOneRowsTopDownArray(array, i);
    }
}

// Метод: Создается двухмерный массив с заданными параметрами (кол-во строк, кол-во столбцов)
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // rows = 3, columns = 4 Создание двумерного массива случайными целыми числами
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