﻿// Программа, которая принимает на вход число, и проверяет кратно ли оно одновременно 7 и 23.

string reminderSearcher(string? str)
{
    if(str != null)
    {
        try
        {
            string answer;
            int num = int.Parse(str);
            if (((num %7)==0)&&((num%23)==0))
            {
                answer= "It's multiple for 7 and 23";
            
            }
            else
            {
                answer = "It's not multiple for 7 and 23";
            }
            return answer;
        }
        catch (Exception e)
        {
            return "Возникло исключение: " + e.Message;
        }
    }
    return "";
}

Console.WriteLine("Input number: ");
string? inputone = Console.ReadLine();
Console.WriteLine(reminderSearcher(inputone));