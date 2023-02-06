/*Требуется написать программу, производящую согласно утверждению Гольдбаха, разложение заданного чётного числа.
 * Из всех пар простых чисел, сумма которых равна заданному числу, требуется найти пару, содержащую наименьшее простое число.*/
//Ввод и проверка на четность
int N = 0;
int PN1 = 0;
int PN2 = 0;
do
{
    Console.Clear();
    Console.Write("Введите положительное целое четное число :");
    N = Convert.ToInt32(Console.ReadLine());
}
while (N % 2 != 0);
Console.WriteLine($"Введено число: {N}");

for(int i=N; i>2; i--)
{
    if (ValidatePrimeNumber(i))
    {
        PN1 = i;
        int temp = N - i;
        if (ValidatePrimeNumber(temp))
        {
            PN2 = temp;
            break;
        }
    }
}
Console.WriteLine($"Наименьшая пара простых чисел, сумма которых равна {N} :   {PN1} и {PN2}");
Console.ReadKey();

// Проверка: является ли число <number> простым
bool ValidatePrimeNumber(int number)
{
    bool c = false;
    for (int i = 2; i < number; i++)
    {
        c = !(number % i == 0);
        if (!c)
            break;
    }
    return c;
}