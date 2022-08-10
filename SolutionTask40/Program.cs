/* Задача №40
Напишите программу, которая принимает на вход три числа и проверяет,
 может ли существовать треугольник с сторонами такой длины.*/

int sideA = 0;
int sideB = 0;
int sideC = 0;
ReadSides();
bool res = TestTriangle();
PrintAnswer(res);


//метод чтения данных
void ReadSides()
{
    Console.Write("Введите число 1: ");
    sideA = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 2: ");
    sideB = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число 3: ");
    sideC = int.Parse(Console.ReadLine() ?? "");
}
//метод вычисления
bool TestTriangle()
{
    bool answer = ((sideA + sideB > sideC) 
    && (sideA + sideC > sideA)
     && (sideB + sideC > sideA)) ? true : false;
     //perem = (условие) ?значение1: значение2;
     return answer;
}
//метод печати результата
void PrintAnswer(bool answer)
{
    if(answer)
    {
      Console.WriteLine("Из этих отрезков можно составить треугольник");
    }
    else
    {
        Console.WriteLine("Из этих отрезков нельзя составить треугольник");
    }
}