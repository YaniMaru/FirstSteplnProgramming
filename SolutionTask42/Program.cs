/*Задача №42
Напишите программу, которая будет
преобразовывать десятичное число в двоичное.
Например:  45 -> 101101   3 -> 11     2 -> 10*/

Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()),2));


int number = int.Parse(Console.ReadLine());
string outLine = Convert.ToString(number,2);
Console.WriteLine(outLine);