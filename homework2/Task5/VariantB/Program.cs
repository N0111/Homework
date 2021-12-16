// Коробчук А.
// 5.
// Написать программу, которая запрашивает массу и рост человека,
//  вычисляет его индекс массы и сообщает, на сколько кг похудеть или сколько кг набрать для нормализации веса.
Console.Write("Введите рост(в метрах): ");
double h = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вес (в килограмах): ");
double m = Convert.ToDouble(Console.ReadLine());
double i = m / (h * h);
Console.WriteLine($"ИМТ = {i:F2}");

if (i < 19)
{
    double m1 = Convert.ToDouble(19 * h * h - m);
    Console.WriteLine("Вам стоит поправиться на " + m1 + " кг.");
}
else if (i > 25)
{
    double m1 = Convert.ToDouble(m - 25 * h * h);
    Console.WriteLine("Вам стоит похудеть на " + m1 + " кг.");
}
else
{
    Console.WriteLine("Вы в норме");
}