/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
Console.Write("Сколько чисел будет введено? : ");
int n = Convert.ToInt32(Console.ReadLine());
double i=0;
string m = string.Empty;
int count = 0;
do
{
    Console.Write($"Осталось : {n}\n Ваше число : ");
    i = Convert.ToDouble(Console.ReadLine());
    Console.Clear();
    count += i > 0 ? 1 : 0;
    m = $"{m} {i}";
    n--;
    Console.WriteLine(m);
}
while (n > 0);
Console.Write($"Введено {count} положительный чисел.");
Console.ReadKey();