Console.WriteLine("Я скажу какое число больше...\n");
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = a > b ? a : b;
Console.WriteLine($"Из двух чисел {a} и {b} большим является {c}");
