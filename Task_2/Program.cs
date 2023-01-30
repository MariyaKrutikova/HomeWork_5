/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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

int[] GetArray(int dimantion)
{
    int[] array = new int[dimantion];
    Random rnd = new Random();
    for (int i = 0; i < dimantion; i++)
    {
        array[i] = rnd.Next(0, 15);
    }
    return array;
}

int SumOfElement(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum +array[i];
    }
    return sum;
}

int dimantion = GetDimantion("Задайте размерность массива: ");
int[] array = GetArray(dimantion);
Console.WriteLine(string.Join(", ", array));
int sum = SumOfElement(array);
Console.WriteLine($"Сумма элементов массива на нечётных позициях состовялет: {sum}");