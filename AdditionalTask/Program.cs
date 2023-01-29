int max = 0;
int max1 = 0;
int inp = 0;
Console.WriteLine("Вводите любые числа.");
do
{
    inp = Convert.ToInt32(Console.ReadLine());
    if (inp > max)
    {
        max1 = max;
        max = inp;
    }
} while (inp != 0);
Console.WriteLine($"Первое по величине число: {max}\nВторое по величине число: {max1}");