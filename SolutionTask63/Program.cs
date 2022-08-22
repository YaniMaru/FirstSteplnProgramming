﻿/*---------------------------------------------------------------------------------
Задача №63
Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
---------------------------------------------------------------------------------*/


Console.Clear();

int ReadData()
{
    Console.WriteLine("Задайте число: ");
    return int.Parse(Console.ReadLine());
}

//Стек
//1 4 - 3 out
//2 3 - 2 out 2
//3 2 -   out 1


int NuturalNumberPrinter(int num)
{
    if(num == 2 )return 1;
    else
    {
        num--;
        Console.WriteLine(num);
        Console.Write(NuturalNumberPrinter(num) + " ");
    }
    return num;
}


int inputNumber = ReadData();
NuturalNumberPrinter(inputNumber+2);