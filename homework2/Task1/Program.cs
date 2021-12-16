// Коробчук А.
//1. Написать метод, возвращающий минимальное из трёх чисел.
Console.Write("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b && a < c)
{
    Console.WriteLine("Меньше число a: " + a);
}
else if (b < c)
{
    Console.WriteLine("Меньше число b: " + b);
}
else
{
    Console.WriteLine("Меньше число c: " + c);
}