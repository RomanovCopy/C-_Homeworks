Console.Clear();
Console.Write("Все четные числа из интервала от 1 до введеного\nВведите число ");
int n = Convert.ToInt32(Console.ReadLine());
string result = "";
int c = n > 1 ? -1 : 1;
for (int a = n; a != 0; a = a + c)
{
    result = a % 2 == 0 ? $"{result} {a}" : result;
}
Console.WriteLine(result.Length > 1 ? $"Все четные числа из интервала от 1 до {n}: " : $"В интервале от 1 до {n} четных чисел нет.");
Console.Write(result);
