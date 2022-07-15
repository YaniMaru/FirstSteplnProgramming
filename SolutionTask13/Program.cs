// Программа, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine("Введите число: ");
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
char[] arr = inputLine.ToCharArray();
if(arr.Length>=3)
{
Console.WriteLine($"Третья цифра {arr[2]}");
}
else
{
Console.WriteLine("Третья цифра отсутствует");
}
}


// Console.WriteLine("Введите число: ");
// string? inputLine = Console.ReadLine();
// if (inputLine != null)
// {
//     int num= int.Parse(inputLine);
//     if (num >100)
//     {
//         string stringNum = inputLine.ToString();
//         Console.Write(stringNum[2]);
//     }
//     else
//     {
//         Console.WriteLine("Третья цифра отсутствует");
//     }
// }

