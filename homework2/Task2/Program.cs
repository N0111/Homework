// Коробчук А.
// 2. Написать метод подсчета количества цифр числа.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
long s = 0;
while (a > 0)
{
    s = s + a % 10;
    a = a / 10;
}
Console.WriteLine(s);

