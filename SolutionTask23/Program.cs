// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
string? inputLineN = Console.ReadLine();
//Метод возведения в степень "3" числа N
void Cube()
{
    if (inputLineN != null)
    {   
        int numberN = int.Parse(inputLineN);
        string lineN = "";
        string lineNNN = string.Empty;
        int s = 1; 
        while (s <= numberN)
        {
            lineN = lineN + s + " ";
            lineNNN = lineNNN + s * s * s + " ";
            s++;
        }
        Console.WriteLine(lineN);
        Console.WriteLine(lineNNN);
    }
}
Cube();








