Console.Clear();
Console.Write("Является ли введеное число четным...?\nВведите число: ");
int a = Convert.ToInt32(Console.ReadLine());
bool result = a % 2 == 0;
Console.WriteLine(result ? $"Число {a} является четным." : $"Число {a} не является четным.");
