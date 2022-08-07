/* ---------------------------------------------------------------------------------
№34 Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
[845, 222, 367, 123 -> 1
* Отсортировать массив методом пузырька
---------------------------------------------------------------------------------*/

//метод возвращает массив заполненый случайными числами от 100 до 999
int[] FillingArrey(int length)
{
    int[] array = new int[length];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < length)
    {
        array[i] = numberSintezator.Next(100, 1000);
        i++;
    }
    return array;
}

//Метод печатает массив
void PrintIntArray(int[] array)
{
    int i = 0;
    Console.Write("[");
    while (i < array.Length - 1)
    {
        Console.Write(array[i] + ", ");
        i++;
    }

    Console.Write(array[i]);
    Console.WriteLine("]");
}
//Метод подсчета колличества четных элеметов
int ColculateTask(int[] array)
{
    int numberOfEvenElements = 0;
    int i = 0;

    while (i < array.Length)
    {
        if (array[i] % 2 == 0)
        {
            numberOfEvenElements++;
        }
        i++;
    }
    return numberOfEvenElements;
}

//Метод, сортирующий массив чисел (по возрастанию)
int[] BubbleSort(int[] array)
{
    int temporary;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                temporary = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temporary;
            }
        }
    }
    return array;
}

int length = 15;
int[] bufferArrey = FillingArrey(length);
int result = ColculateTask(bufferArrey);

PrintIntArray(bufferArrey);
Console.WriteLine($"Количество чётных чисел в массиве: {result}."); 
Console.WriteLine("Отсортированный массив:");
PrintIntArray(BubbleSort(bufferArrey));