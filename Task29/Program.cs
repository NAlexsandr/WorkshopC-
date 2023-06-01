// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
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
for (int i = 0; i < array.Length; i++)

    Console.Write(array[i] + " ");
}

int i = Promp("Введите длину массива: ");
int[] arr = new int[i];
arr = FillArray(arr, i);
PrintArray(arr);