/*Задача №31
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.*/

// переменные для накапливания результатов
int posetivSum = 0;
int negativSum = 0;

//метод возвращает массив заполненый случайными числами от -9 до 9

int[] FillingArrey()
{
    //выходной массив
    int[] outArray = new int[12];
    //буферная переменная(/вкладывается индекс массива)
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //цикл заполнения массива
    while (i < 12)
    {
        //получаем новое значение
        outArray[i] = numberSintezator.Next(-9, 10);
        //увеличиваем инкримент
        i++;
    }
    //возвращаем значение
    return outArray;
}

//Метод подсчета положительных и отрицательных значений
void ColculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            posetivSum += outArray[i];
        }
        else
        {
            negativSum += outArray[i];
        }
        i++;
    }
}

//Выводим результат на кансоль
void PrintResult()
{
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativSum);
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

//Метод решения задачи наивный
void VariantNaive()
{
    int [] bufferArrey = FillingArrey();
    PrintIntArray(bufferArrey);
    ColculateTask(bufferArrey);
    // ColculateTask(FillingArrey());
    PrintResult();
}

//Метод решения задачи 31 простой
void VariantSimple()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Буфферные переменные
    int i = 0;
    int buf = 0;
    //Цикл заполнения массива
    while (i < 12)
    {
        //Получаем новое значение
        buf = numberSintezator.Next(-9, 9);
        Console.Write(buf +" ");
        //Накапливаем результат
        if (buf >= 0)
        {
            //Элемент положительный
            posetivSum += buf;
        }
        else
        {
            //Элемент отрицательный
            negativSum += buf;
        }
        //Увеличиваем инкремент
        i++;
    }    
    Console.WriteLine();
    //Выводим сумму положительных значений
    Console.WriteLine(posetivSum);
    //Выводим сумму отрицательных значений
    Console.WriteLine(negativSum);
}


int t;
t = Environment.TickCount;
//Вариант 1
VariantNaive();
Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
//Вариант 2
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);