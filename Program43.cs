// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
double k1 = EnterNumber("Введите значение k1 ");
double b1 = EnterNumber("Введите значение b1 ");
double k2 = EnterNumber("Введите значение k2 ");
double b2 = EnterNumber("Введите значение b2 ");
Calculatig(k1,k2,b1,b2);


double EnterNumber(string message)
{
    Console.WriteLine(message);
    return double.Parse(Console.ReadLine()!);
}

void Calculatig(double k1, double k2, double b1, double b2)
{
    if(k1==k2)
    {
        
        if(b1==b2)
        {
            Console.WriteLine($"Прямые совпадают");
        }
        else
        {
            Console.WriteLine($"прямые параллельны");
        }
    }
    else
    {
        double x=(b2-b1)/(k1-k2);
        Console.WriteLine($"Точка пересечения двух прямых [{x:f2};{k1 * x + b1:f2}]");
    }
}