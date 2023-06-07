// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Программа  
int numeric = Promp("Введите количество чисел, которое Вы хотите ввести с клавиатуры: ");
int summ = SumPositive (numeric);
Console.WriteLine($"Кол-во чисел больше 0, введенных Вами с клавиатуры = {summ}");

int SumPositive (int num)                                  //Метод считает, сколько пользователь ввел чисел больше 0  
{
  int sum = 0;
  for (int i = 1; i <= num; i++)
  {
    Console.Write($"{i}-ое число = ");
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    if (result > 0)  {sum = sum + 1;}
   }
 return sum;
}

int Promp(string message)                                    //Метод печатает сообщение, для получения целого числа  
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}