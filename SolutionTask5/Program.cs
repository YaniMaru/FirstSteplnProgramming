// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
string? num1 = Console.ReadLine();
Console.WriteLine("Введите второе число: ");
string? num2 = Console.ReadLine();
if(num1 != null && num2 != null)

{

    int inputNumberOne = int.Parse(num1);
    int inputNumberTwo = int.Parse(num2);
 
         if (inputNumberOne > inputNumberTwo)
        {  
             Console.WriteLine($"Число {num1} больше чем {num2}");
             Console.WriteLine($"Максимальное число  {num1}");
        }
        else if (inputNumberOne ==inputNumberTwo)
        {
        Console.WriteLine($"Числа {num1} и {num2} равны");
        }
        else
        {
             Console.WriteLine($"Число {num2} больше чем {num1}");
             Console.WriteLine($"Максимальное число  {num2}");
        }
}
