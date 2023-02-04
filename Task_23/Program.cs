/*Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.*/
Console.Clear();
Console.Write("Введите число :");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов чисел от 1 до {n}");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} : {Math.Pow(i, 3)}");
}