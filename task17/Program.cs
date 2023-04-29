// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y)
// причем X не равен 0, Y не равен 0 и выдает номер четверти плоскости
// в которой находится эта точка

// Массивы:
//string[] str = {"Точка лежит в первой четверти", "Точка лежит во второй четверти", "Точка лежит в третьей четверти", "Точка лежит в четвертой четверти", "Точка лежит на одной из осей"};
//int [] coords = new int [2];
// Функции:
//int ReadInt(string text)
//{
    //System.Console.WriteLine(text);
    //return = Convert.ToInt32(Console.ReadLine());
//}

int [] coords = new int [2];
coords [0] = ReadInt("Введите кооринату точки X: ");
coords [1] = ReadInt("Введите кооринату точки Y: ");
string[] str = {"Точка лежит в первой четверти", "Точка лежит во второй четверти", "Точка лежит в третьей четверти", "Точка лежит в четвертой четверти", "Точка лежит на одной из осей"};
CheckQuarter(coords, str);

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckQuarter(int[] array, string[] print);

if(array [0] > 0 && array [1] > 0)
{
    System.Console.WriteLine(print [0]);
}
else if (array [0] < 0 && array [1] > 0)
{
    System.Console.WriteLine(print [1]);
}
else if (array [0] < 0 && array [1] < 0)
{
    System.Console.WriteLine(print [2]);
}
else if (array [0] > 0 && array [1] < 0)
{
    System.Console.WriteLine(print [3]);
}
else
{
    System.Console.WriteLine(print [4]);
}
int [] coords = new int [2];
coords [0] = ReadInt("Введите кооринату точки X: ");
coords [1] = ReadInt("Введите кооринату точки Y: ");
string[] str = {"Точка лежит в первой четверти", "Точка лежит во второй четверти", "Точка лежит в третьей четверти", "Точка лежит в четвертой четверти", "Точка лежит на одной из осей"};
CheckQuarter(coords, str);