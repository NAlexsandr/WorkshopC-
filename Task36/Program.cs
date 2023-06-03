// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
                                                                  // Программа
int j = Promp("Задается кол-во чисел в массиве, который будет заполненный случайными числами от 1 до 100: ");
int[] array = CreateArrayRndInt(j, 0, 101);
int total = SumElementNotEven(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Сумма элементов, стоящих на нечётных позициях массиве = {total}");
                                                                 //Метод считает сумму элементов в массиве, стоящих на нечётных позициях 
int SumElementNotEven(int[] arr)                                 
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}
                                                                    //Метод заполняет массив заданной величины в указанном диапозоне (size, min, max)
int[] CreateArrayRndInt(int size, int min, int max)          
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}
                                                                    //Метод выводит на экран значения массива
void PrintArray(int[] arr, string sep = ",")                 
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else Console.Write($"{arr[i]}");
    }
}
                                                                    //Метод печатает сообщение, для получения целого числа
int Promp(string message)                                     
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}