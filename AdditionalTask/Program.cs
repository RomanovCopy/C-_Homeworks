Console.Clear();
Console.Write("Введите колличество кустов ( от 3 до 1000 ): ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];//массив для хранения урожайности
int l = 0;//урожай с левого куста
int c = 0;//урожай с центрального куста
int p = 0;//урожай с правого куста
/*Ввод данных*/
for (int i = 0; i < n; i++)
{
    Console.Clear();
    Console.WriteLine("Введите урожайность каждого куста.");
    Console.WriteLine($"Всего кусов: {n}");
    Console.Write($"Куст {i + 1} :");//для удобства избавляем от куста 0
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < n; i++)
{
    if (i == 0)//сбор у нулевого куста
    {
        l = array[n - 1];//левый куст
        p = array[i + 1];//правый куст
    }
    else if (i == n - 1)//сбор у последнего куста
    {
        p = array[0];
        l = array[i - 1];
    }
    else//сбор у всех остальных кустов
    {
        l = array[i - 1];
        p = array[i + 1];
    }
    c = array[i];//центральный куст
    Console.WriteLine($"Куст {i + 1} сбор: {l + p + c}");
}