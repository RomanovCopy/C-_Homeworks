Console.Clear();
Console.Write("Какое число больше...?\nВведите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a > b ? a : b;
Console.WriteLine($"Из двух чисел {a} и {b} большим является {c}");
