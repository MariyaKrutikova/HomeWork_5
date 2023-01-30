/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

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
        array[i] = rnd.Next(100,1000);
    }
    return array;
}

int evenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    } 
    return count;
}

int dimantion = GetDimantion("Задайте размерность массива: ");
int[] array = GetArray(dimantion);
Console.WriteLine(string.Join(", ", array));
int count = evenNumbers(array);
Console.WriteLine($"Колличество четных элементов в массиве составляет: {count}");