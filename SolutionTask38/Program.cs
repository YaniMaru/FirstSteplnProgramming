/*---------------------------------------------------------------------------------
Задайте массив вещественных чисел. Найдите разницу между максимальным и
минимальным элементов массива.
[3 7 22 2 78] -> 76                  [2 0,4 9 7,2 78] -> 77,6
---------------------------------------------------------------------------------*/

//Метод возвращает массив заполненый случайными вещественными числами 
double[] FillingArrey()
{
    double[] array = new double[10];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < array.Length)
    {
        array[i] = numberSintezator.Next(0, 101) / 10.0;
        i++;
    }
    return array;
}
//Метод печатает массив
void PrintIntArray(double[] array)
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
//метод вычисления разницы между max и min элементами массива.
double ColculateTask(double[] array)
{
    double max = 0;
    double min = double.MaxValue;
    int i = 0;

    while (i < array.Length)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        i++;
    }
    Console.WriteLine($"Минимальное значение: {min}\nМаксимальное значение: {max}");
    double difference = (max - min);
    return difference;
}
//Решение задачи
void Variant()
{
    double[] bufferArrey = FillingArrey();
    PrintIntArray(bufferArrey);
    double result = ColculateTask(bufferArrey);
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {result}.");
}

Variant();