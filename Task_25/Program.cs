/* Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
Нельзя использовать Math.Pow();*/
Console.Clear();
Console.Write("Введите число и степень: \n");
Console.Write("Число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень: ");
int B = Convert.ToInt32(Console.ReadLine());
int d = B;
int result = 1;
while (d > 0)
{
    result = result * A;
    d--;
}
Console.Write($"{A} в степени {B} = {result}");