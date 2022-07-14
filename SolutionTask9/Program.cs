// Программа, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Метод решения задачи 1 вариант


void variant1(System.Random numberSintezator)
{
    int number = numberSintezator.Next(10, 100);
    Console.WriteLine(number);
    //создаем переменные, куда положим 1 и 2 цифры
    int firstNumber = number / 10; //для первой цифры делим на 10
    int secondNumber = number % 10; //для второй цифры остаток от деления на 10

    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }
}



//Метод решения задачи 2 вариант
void variant2()
{
    int numberKr = new Random().Next(10, 100);
    Console.Write("The random number is: ");
    Console.WriteLine(numberKr);
    string stringNum = numberKr.ToString();
    Console.Write("The bigges digit is: ");
    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else
    {
        Console.WriteLine(stringNum[1]);
    }
}


//Метод решения задачи 3 вариант
void variant3(System.Random numberSintezator)
{
    char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();

    Console.WriteLine(digits);

    int firstNumber = ((int)digits[0])-48;
    int secondNumber = ((int)digits[1])-48;

    int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;

    Console.WriteLine(resultNumber);
}

System.Random numberSintezator = new Random();

variant1(numberSintezator);
variant2();
variant3(numberSintezator);