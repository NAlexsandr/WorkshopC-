// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// ПРОГРАММА

int dimensionA1 = Promp("Введите кол-во строк в первой матрице А: ");
int dimensionA2 = Promp("Введите кол-во столбцов в первой матрице А: ");
int[,] array1 = CreateMatrixRndInt(dimensionA1, dimensionA2, 1, 10);  // Создаем 1-й двухмерный массив
Console.WriteLine("Первая матрица А:  ");
PrintMatrix(array1);
int dimensionB1 = Promp("Введите кол-во строк в первой матрице B: ");
int dimensionB2 = Promp("Введите кол-во столбцов в первой матрице B: ");
int[,] array2 = CreateMatrixRndInt(dimensionB1, dimensionB2, 1, 10);  // Создаем 2-й двухмерный массив
Console.WriteLine("Вторая матрица B:  ");
PrintMatrix(array2);
if (array1.GetLength(0) != array2.GetLength(1))    //Проверяем, можно ли эти матрицы перемножать
{
    Console.WriteLine("Эти матрицы нельзя перемножить !!!!!!!!!!!!!");
    return;
}
int[,] matrixMulti = MatrixMultiplication(array1, array2);
Console.WriteLine("Матрица, полученная в результате перемножения A*B  ");
PrintMatrix(matrixMulti);


// Метод: Перемножает заданную строку 1-й матрицы на заданный столбец 2-й матрицы
int MultiplyRowByColumn(int[,] array1, int[,] array2, int rows, int colums)
{
    int multiplyRowByColumn = 0;
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        multiplyRowByColumn = multiplyRowByColumn + array1[rows, i] * array2[i, colums];
    }
    return multiplyRowByColumn;
}

// Метод: Перемножает 1-ю матрицу 2-ю матрицу
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] multiMatrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            multiMatrix[i, j] = MultiplyRowByColumn(array1, array2, i, j);
        }
    }
    return multiMatrix;

}

// Метод: Создается целочисленный двухмерный массив с заданными параметрами (кол-во строк, кол-во столбцов)
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

// Метод печатает сообщение, для получения целого числа
int Promp(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}