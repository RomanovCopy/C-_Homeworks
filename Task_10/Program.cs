Console.Clear();
Console.Write("Введите число в интервале от 100 до 999 включительно: ");
int n = Convert.ToInt32(Console.ReadLine());
int n2 = (n%100)/10;
Console.WriteLine(n2);