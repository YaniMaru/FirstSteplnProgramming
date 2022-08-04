﻿/*---------------------------------------------------------------------------------- 
  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
* Ввести с клавиатуры длину массива и диапазон значений элементов 
----------------------------------------------------------------------------------*/
System.Random numberSintesator = new Random();
//Option with an array of 8 elements
void VariantOne()
{
    int i = 0;
    Console.Write("[");
    while (i < 8 - 1)
    {
        Console.Write(numberSintesator.Next(0, 2) + ",");
        i++;
    }
    Console.Write(numberSintesator.Next(0, 2));
    Console.WriteLine("]");
}
//Option with an array of a given number of elements
void VariantTwo()
{
    Console.Write("Введите длинну массива: ");
    int length = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите нижнюю границу рандомайзера: ");
    int bottomLine = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите верхнюю границу рандомайзера: ");
    int topLine = Convert.ToInt32(Console.ReadLine());

    // Forming an array with user data
    void CustomArray()
    {
        int i = 0;
        Console.Write("[");
        while (i < length - 1)
        {
            Console.Write(numberSintesator.Next(bottomLine, topLine + 1) + ",");
            i++;
        }
        Console.Write(numberSintesator.Next(bottomLine, topLine + 1));
        Console.Write("]");
    }
    CustomArray();
}

VariantOne();
VariantTwo();
