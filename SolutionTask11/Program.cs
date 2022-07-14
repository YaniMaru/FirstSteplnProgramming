// Программа, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
//Решение 1
System.Random numberSintezator = new Random();
int number = numberSintezator.Next(100, 1000);
Console.WriteLine(number);
int firstNumber = number / 100;
int secondNumber = number % 10;
int Result = firstNumber * 10 + secondNumber;

Console.WriteLine(Result);
//Решение 2
void middleDigitCutter()
{
    int number = new Random().Next(100,1000);
    Console.Write("The random number is: ");
    Console.WriteLine(number);
    string stringNum = number.ToString();
    Console.Write("The modified number is: ");
    Console.Write(stringNum[0]);
    Console.WriteLine(stringNum[2]);
}

middleDigitCutter();