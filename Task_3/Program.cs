/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int GetDimantion(string message)
{
    Console.WriteLine(message);
    int dimantion = 0;
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out dimantion) & dimantion > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод данных. Повторите ввод: ");
        }
    }
    return dimantion;
}

double[] GetArray(int dimantion)
{
    double[] array = new double[dimantion];
    Random rnd = new Random();
    for (int i = 0; i < dimantion; i++)
    {
        array[i] = rnd.NextDouble()*7;
    }
    return array;
}

(double, double) GetMinMaxNumbers(double[] array)
{
    double minNumber = array[0];
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
        if (array[i] > maxNumber) maxNumber = array[i];
    }
    return (minNumber, maxNumber);
}

int dimantion = GetDimantion("Задайте размерность массива: ");
double[] array = GetArray(dimantion);
Console.WriteLine(string.Join(", ", array));
(double minNumber, double maxNumber) = GetMinMaxNumbers(array);
Console.WriteLine($"Минимальный элемент массива: {minNumber}");
Console.WriteLine($"Максимальный элемент массива: {maxNumber}");
