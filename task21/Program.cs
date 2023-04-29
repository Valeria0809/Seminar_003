// Задача 21. 
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6) B(2,1) --> 5,09
// A (7, -5) B (1, -1) --> 7,21

//System.Console.WriteLine(Math.Pow()); - возведение в квадрат
//System.Console.WriteLine(Math.Sqrt()); - возведение в степень
//System.Console.WriteLine(Math.Round(Math.Sqrt(_)_); - округление результата

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] coardsA = new int [2];

coardsA[0] = ReadInt("Введите координату X точки A ");
coardsA[1] = ReadInt("Введите координату Y точки A ");

int[] coardsB = new int [2];

coardsB[0] = ReadInt("Введите координату X точки B ");
coardsB[1] = ReadInt("Введите координату Y точки B ");

double distance = Math.Sqrt(Math.Pow(coardsA[0] - coardsB[0], 2) + Math.Pow(coardsA[1] - coardsB[1], 2));
System.Console.WriteLine(Math.Round(distance, 3));