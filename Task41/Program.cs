/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
Console.Write("Сколько чисел будет введено? : ");
int n = Convert.ToInt32(Console.ReadLine());//колличество вводимых чисел
double i=0;//введеное число
string m = string.Empty;//строка для отображения введенных чисел
int count = 0;//колличество положительных чисел
do
{
    Console.Write($"Осталось : {n}\n Ваше число : ");
    i = Convert.ToDouble(Console.ReadLine());
    Console.Clear();
    count += i > 0 ? 1 : 0;//обработка введенного числа
    m = $"{m} {i}";//формирование строки ввода
    n--;
    Console.WriteLine(m);
}
while (n > 0);
Console.Write($"Введено {count} положительный чисел.");
Console.ReadKey();