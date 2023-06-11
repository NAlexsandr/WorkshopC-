// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Создаем двухмерный массив: ");                   // Программа   
int[,] arr = CreateMatrixRndInt(5, 6, 1, 10);            
PrintMatrix(arr);
int[] rowscolums = Promp2Number("Введите номер строки и номер столбца через пробел или запятую: "); // Получаем на входе позицию элемента
bool find = FindArrayElement (arr, rowscolums[0], rowscolums[1]);                                   // Смотрим, есть ли такая позиция (Да/Нет)
if (find)                                                                                           // Выводим на экран сообщение
{
    Console.Write($" -> Значение элемента в двухмерном массиве = {arr[rowscolums[0] - 1, rowscolums[1] - 1]} ");
}
else {Console.Write("-> Такого элемента в двухмерном массиве нет ");}


                                                     // Метод принимает позицию элемента двумерном массиве,
                                                     // и возвращает true (есть такая позиция в массиве) или false (нет такой позиции)
bool FindArrayElement (int[,] arr, int rows, int colums)                                                               
{ if (rows > 0
      & rows <= arr.GetLength(0)
      & colums > 0
      & colums <= arr.GetLength(1)
    )
     return true;
  else return false;
}

int[] Promp2Number(string message)                                  // Метод принимает два числа с консоли, написанные через пробел или запятую
{
    int[] array = new int[2];
    Console.Write(message);
    string value = Console.ReadLine();
    string[] subs = value.Split(',',' ');    // Строки разделяются запятой или пробелом
    array[0] = Convert.ToInt32(subs[0]);
    array[1] = Convert.ToInt32(subs[1]);
    return array;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  // Метод заполняет двумерный массив случайными целыми числами
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

void PrintMatrix(int[,] matrix)                                       // Метод выводит на экран двухмерный целочисленный массив 
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