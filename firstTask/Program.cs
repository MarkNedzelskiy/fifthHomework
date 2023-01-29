/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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
        array[i] = randomInt.Next(1, 1000);    
    }

    return array;
}

int CountEvenNumbers (int[] array)
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

int arrayLength = ArrayLength();
int[] randomArray = CreateArray(arrayLength);
int countEvenNumbers = CountEvenNumbers(randomArray);
Console.WriteLine(countEvenNumbers);
