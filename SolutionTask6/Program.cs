// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
string? num1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? num2 = Console.ReadLine();
Console.WriteLine("Введите третье число: ");
string? num3 = Console.ReadLine();
if(num1 != null && num2 != null && num3 != null)

{
    int inputNumberOne = int.Parse(num1);
    int inputNumberTwo = int.Parse(num2);
    int inputNumberThree = int.Parse(num3);
    int maxNumber = inputNumberOne;
    if (inputNumberTwo > maxNumber)
    {
        maxNumber=inputNumberTwo;
    }
    if (inputNumberThree > maxNumber)
    {
        maxNumber=inputNumberThree;
    }
    Console.Write("Mаксимальное число - ");
    Console.Write(maxNumber);
} 
