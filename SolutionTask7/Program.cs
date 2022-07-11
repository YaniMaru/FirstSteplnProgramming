// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int a = int.Parse(inputLine);
    if (a % 2==0)
    {
    Console.Write($"Число {inputLine} является четным");  
    }
    else
    {
     Console.Write($"Число {inputLine}  является  не четным");
    }
 }