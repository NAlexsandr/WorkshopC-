// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел
//в массиве.[345, 897, 568, 234] -> 2
                                                              //Программа
int j  = Promp("Задается кол-во чисел в массиве, который будет заполненный случайными положительными трёхзначными числами: ");
int[] array = CreateArrayRndInt(j, 99, 1000);                
int count = GetAmountNumberDivideTo2(array);   
PrintArray(array);
Console.WriteLine();
Console.Write($"Количество трехзначных ЧЕТНЫХ чисел в массиве: {count}");

                                                               //Метод считает и показывает количество чётных чисел в массиве
int GetAmountNumberDivideTo2(int[] arr)                       
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) sum = sum + 1;
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