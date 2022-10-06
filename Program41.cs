//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine($"Введите массив вещественных чисел:");
double[] array=CreateArray();
Console.WriteLine($"Количество чисел больше 0 = {CalculatingCount(array)}");


double[] CreateArray()
{
    string[] text = Console.ReadLine().Split(" ");
    double[] array = new double[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
         array[i] = double.Parse(text[i]);
    }
    return array;
}

int CalculatingCount(double[] array)
{
    int count = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
