// Программа, которая принимает на вход координаты двух точек и находит расстояние между
// ними в 2D пространстве.


int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengthAB;

// Считывает координаты точек А и В
void readDataOfPoint()

{
    Console.WriteLine("Введите координату X точки А");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точки B");
    coordYPointB = int.Parse(Console.ReadLine());
}

// Вычисляет расстояние между точками А и В
void conculateLengtAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordXPointA - coordXPointB), 2));
}

readDataOfPoint();
conculateLengtAB();

Console.WriteLine(lengthAB);