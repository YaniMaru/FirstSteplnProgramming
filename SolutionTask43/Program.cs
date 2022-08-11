/*---------------------------------------------------------------------------------
 №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
---------------------------------------------------------------------------------*/
Console.Clear();
double b1;
double k1;
double k2;
double b2;
double y;
double x;

Read();
ColculateTask();
Print();

//метод чтения данных
void Read()
{
    Console.Write("Введите b1: ");
    b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    k2 = Convert.ToDouble(Console.ReadLine());
}
//метод вычисления
void ColculateTask()
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * (b2 - b1) / (k1 - k2) + b1;
}
//метод печати
void Print()
{
    Console.WriteLine($"Пересечение в точке: ({x}; {y})");
}
