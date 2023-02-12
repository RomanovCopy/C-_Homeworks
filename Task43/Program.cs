/*Напишите программу, которая найдёт точку пересечения двух прямых, 
 * заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 * значения b1, k1, b2 и k2 задаются пользователем.*/

Console.Write("Введите через запятую параметры для первой прямой: \"K1\", \"B1\"");
double[] line1 = Console.ReadLine().Split(',').Select((x) => Convert.ToDouble(x)).ToArray();//получение параметров первой прямой
Console.Write("Введите через запятую параметры для второй прямой: \"K2\", \"B2\"");
double[] line2 = Console.ReadLine().Split(',').Select((x) => Convert.ToDouble(x)).ToArray();//получение параметров второй прямой
bool crossing = line1[0] != line2[0];//проверка на пересечение
if (crossing)
{//прямые пересекаются
    double x = (line1[1] - line2[1]) / (line2[0] - line1[0]);//координата пересечения X
    double y = line1[1] * x + line1[1];//координата пересечения Y
    Console.WriteLine($"Прямые пересекаются в точке с координатами X = {x}, Y = {y}");
}
else
{//прямые либо совпадают, либо паралельны
    Console.WriteLine("Прямые не пересекаются.");
}
Console.ReadKey();
