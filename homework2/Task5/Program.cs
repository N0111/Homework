// Коробчук А.
// 5.
// а) Написать программу, которая запрашивает массу и рост человека,
//  вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
//   набрать вес или всё в норме.

Console.Write("Введите рост(в метрах): ");
double h = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вес (в килограмах): ");
double m = Convert.ToDouble(Console.ReadLine());
double i = m / (h * h);
Console.WriteLine($"ИМТ = {i:F2}");

if (i < 19)
{
    Console.WriteLine("Вам стоит немного поправиться");
}
else if (i > 25)
{
    Console.WriteLine("Вам стоит немного похудеть");
}
else
{
    Console.WriteLine("Вы в норме");
}