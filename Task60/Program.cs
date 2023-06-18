// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)

// ПРОГРАММА
int[,,] array3d = CreateArray3dRndInt(2, 2, 2);
PrintArray3d(array3d);


// Метод: Создается целочисленный трехмерный массив с заданными параметрами (кол-во строк, кол-во столбцов)
int[,,] CreateArray3dRndInt(int x, int y, int z) // rows = 3, columns = 4 Создание двумерного массива случайными целыми числами
{
    //                        0      1      
    int[,,] array3d = new int[x, y, z];
    int index = 0;
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = 10 + index;
                index++;
            }
        }
    }
    return array3d;
}

// Метод: Вывод на экран трехмерного массива 
void PrintArray3d(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i, j, k],6} ({i},{j},{k})");
            }

        }
        Console.WriteLine();
    }
}