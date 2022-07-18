// Программa, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNN = string.Empty;
    int s = 1;
    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNN = lineNN + s * s + " ";
        s++;
    
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}


