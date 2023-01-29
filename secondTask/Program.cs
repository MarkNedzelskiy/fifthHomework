/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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
        array[i] = randomInt.Next(-1000, 1000);    
    }

    return array;
}

int numbersSummInEvenPosition (int[] array)
{
    int summ = 0;
    
    for (int i = 1; i <= array.Length; i = i + 2)
    {
        summ += array[i];
    }

    return summ;
}

int arrayLength = ArrayLength();
int[] array = CreateArray(arrayLength);
int summ = numbersSummInEvenPosition(array);
Console.WriteLine(summ);