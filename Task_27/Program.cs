/*Напишите программу, которая принимает на вход
 число и выдаёт сумму цифр в числе.*/
Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n < 0 ? n * -1 : n;
int s = 0;
while (n1 > 0)
{
    s = s + n1 % 10;
    n1 = n1 / 10;
}
Console.Write($"Сумма цифр в числе {n}: {s} ");