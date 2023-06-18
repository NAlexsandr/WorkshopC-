// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// ПРОГРАММА
int[,] array2d = CreateMatrixRndInt(7, 7, 1, 10);  // Создаем двухмерный массив
PrintMatrix(array2d);
Console.WriteLine();
int[] array1d = Array2dToArray1dSumElemet(array2d);  // Для проверки печатаем одномерный массив с суммами всех элементов строк
PrintArray(array1d);
int rows = IndexMinELementArray(array1d);            // Получаем Индекс наименьшего числа (в нашем случае - номер строки),
                                                     // с наименьшей суммой элементов
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой всех элементов - {rows}");
Console.WriteLine();


// Метод: Переводит Двухмерный массив в одномерный, где каждый элемент - это сумма всех элементов в строке,
//        а индекс элемента - это номер строки двухмерного массива
int[] Array2dToArray1dSumElemet(int[,] array2d)
{
    int[] array1d = new int[array2d.GetLength(0)];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        array1d[i] = 0;
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array1d[i] = array1d[i] + array2d[i, j];
        }
    }
    return array1d;
}
// Метод: Ищет МIN по значению элемент в одномерном массиве и выдает его Индекс
int IndexMinELementArray(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    int i = 1;
    while (i < array.Length)
    {
        if (array[i] < min)
        {
            min = array[i];
            indexMin = i;
        }
        i = i + 1;
    }
    return indexMin + 1;
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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}