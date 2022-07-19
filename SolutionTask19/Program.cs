//  Программа, которая принимает на вход пятизначное число и проверяет,является ли оно палиндромом.

void Palindrom(int num)
{
    int D1 = num / 10000;
    int D2 = (num / 1000) % 10;
    int D3 = (num / 100) % 10;
    int D4 = (num / 10) % 10;
    int D5 = num % 10;

    if (D1 == D5 && D2 == D4)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num}  не является  палиндромом");
    }
}

void Variant2()
{
Console.WriteLine("Введите пятизначное число: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    char[] arr = inputLine.ToCharArray();
    if (arr.Length >= 5)
    {
        if ((arr[0] == arr[4]) && (arr[1] == arr[3]))
        {
            Console.Write($"Число {inputLine} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {inputLine}  не является  палиндромом");
        }
    }
}
}


Console.WriteLine("Введите пятизначное число: ");
string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int num = int.Parse(inputNumber);
    Palindrom(num);
}


Variant2();