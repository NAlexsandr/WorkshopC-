// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Программа
Console.WriteLine("Программа находит точку пересечения (х,y) двух прямых на плоскости, заданных формулой y = k*x + b");
Console.WriteLine("Вам нужно ввести коэффициенты, задающие первую прямую - k1, b1 и вторую прямую - k2, b2 ");
Console.WriteLine();
double k1 = Promp("Введите число k1: ");
double b1 = Promp("Введите число b1: ");
double k2 = Promp("Введите число k2: ");
double b2 = Promp("Введите число b2: ");
string mes = LineIntersection(k1, b1, k2, b2);
Console.WriteLine(mes);


//Метод найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 
string LineIntersection(double k1, double b1, double k2, double b2)
{
    string result = "";
    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = x * k1 + b1;
        string xs = Convert.ToString(x);
        string ys = Convert.ToString(y);
        result = "Координаты точки пересечения двух прямых на плоскости: x = " + xs + ", y = " + ys;
        return result;
    }
    else
    {
        if (b1 != b2)
    {
        result = "Эти прямые параллельны";
        }

        if (b1 == b2)
    {
        result = "Эти прямые совпадают";
    }
    }
    
    return result;
}

double Promp(string message)                                    //Метод печатает сообщение, для получения числа Double  
{
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}