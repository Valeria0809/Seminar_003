//Задача 18.
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());
string[] array = {"Точка в первой четверти X > 0, Y > 0", "Точка во второй четверти X < 0, Y > 0", "Точка в третьей четверти X < 0, Y < 0", "Точка в четвертой четверти X > 0, Y < 0", "Введено не корректное число"};
if(num == 1)
{
    System.Console.WriteLine(array[0]);
}
else if (num == 2)
{
    System.Console.WriteLine(array[1]);
}
else if (num == 3)
{
    System.Console.WriteLine(array[2]);
}
else if(num == 4)
{
    System.Console.WriteLine(array[3]);
}
else
{
    System.Console.WriteLine(array[4]);
}
