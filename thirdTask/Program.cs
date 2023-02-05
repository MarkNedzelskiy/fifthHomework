/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int ArrayLength()
{
    Console.WriteLine("Введите размер массива");
    int length;
    
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out length) && length > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите число больше 1");
        }
    }

    return length;
}

double[] CreateArray (int length)
{
    Random random = new Random();
    double[] array = new double[length];
    
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100, 2);    
    }

    return array;
} 

double FindDiffMinMax (double[] arr)
{
    var min = arr[0];
    var max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    double diff = max - min;
    return diff;
}

var length = ArrayLength();
double[] array = CreateArray(length);
Console.WriteLine(string.Join(" ; ", array));
double diff = FindDiffMinMax(array);
Console.WriteLine(Math.Round(diff, 2));