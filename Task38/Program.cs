// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

                                                                     // Программа
int count = Promp("Задается кол-во чисел в массиве, который будет заполненный случайными ВЕЩЕСТВЕНЫМИ числами от 1 до 100: ");
double[] array = CreateArrayRndDouble(count, 0, 101);
double total = DifferenceMaxMin(array);
PrintArrayDouble(array);
Console.WriteLine();
Console.Write($"Разница между MAX и MIN элементами массива = {total}");

                                                                      // Метод находит разницу между максимальным и минимальным элементов массива
double DifferenceMaxMin(double[] arr)                                
{
    double diff = 0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) 
        {
            min = arr[i];
        }
        if (arr[i] > max) 
        {
            max = arr[i];;
        }
    }
    diff = max - min;
    return diff;
}
                                                                      //Метод заполняет массив заданной величины в указанном
                                                                      //диапозоне вещественныи числами, с округлением до числа round (size, min, max)
double[] CreateArrayRndDouble(int size, int min, int max, int round = 2)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, round);
    }
    return arr;
}
                                                                       // Метод выводит на экран значения массива вещественных чисел
void PrintArrayDouble(double[] arr, string sep = ",")                  
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write ($"{arr[i]}{sep} ");
        else Console.Write ($"{arr[i]}");
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

