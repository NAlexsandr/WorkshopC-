﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int Promp(string message)                         //Метод печатает сообщение, для получения целого числа
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] FillArray(int[] array, int count)
{
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[" + array[0] + ", ");
    int j = array.Length;
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[j - 1] + "]");
}

int i = Promp("Введите длину массива: ");
int[] arr = new int[i];
arr = FillArray(arr, i);
PrintArray(arr);