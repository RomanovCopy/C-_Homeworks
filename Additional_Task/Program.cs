Console.Write($"Колличество оценок? : ");
int n = Convert.ToInt32(Console.ReadLine());
Result(Input(n));
Console.ReadKey();
int[] Input(int n)
{
    int[] array = new int[n];
    int data = 0;
    for (int i = 0; i < n; i++)
    {
        do
        {
            Console.WriteLine($"Введено: {i} из {n} \n");
            Console.Write("Очередной день месяца:");
            data = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        } while (data < 0 || data > 31);
        array[i] = data;
    }
    return array;
}
void Result(int[] array)
{
    int runner = 0;
    string EvenNumbers = string.Empty;
    string OddNumbers = string.Empty;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            EvenNumbers = $"{EvenNumbers} {number}";
            runner++;
        }
        else
        {
            OddNumbers = $"{OddNumbers} {number}";
            runner--;
        }
    }
    Console.WriteLine($"Нечетные числа: {OddNumbers}");
    Console.WriteLine($"Четные числа: {EvenNumbers}");
    string result = runner >= 0 ? "Yes" : "No";
    Console.WriteLine($"Результат: {result}");
}