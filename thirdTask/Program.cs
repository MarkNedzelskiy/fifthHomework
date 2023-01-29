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

int[] CreateArray (int length)
{
    Random randomInt = new Random();
    int[] array = new int[length];
    
    for (int i = 0; i < length; i++)
    {
        array[i] = randomInt.Next(-10, 10);    
    }

    return array;
} 

int FindDiffMinMax (int[] arr)
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

    var diff = max - min;
    return diff;
}

var length = ArrayLength();
int[] array = CreateArray(length);
Console.WriteLine(string.Join(", ", array));
var diff = FindDiffMinMax(array);
Console.WriteLine(diff);