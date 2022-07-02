// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] array = new int [5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,99);
}
int min = 0;
int max = 0;

void PrintArray(int [] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void FindMinMax(int [] collection)
{
    min = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > max) max = collection[i];
        if (collection[i] < min) min = collection[i];
    }
    Console.WriteLine(min + " " + max);
}

int diff = max - min;

PrintArray(array);
Console.WriteLine();
FindMinMax(array);
Console.WriteLine(diff);