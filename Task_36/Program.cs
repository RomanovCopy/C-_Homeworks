/*Задайте одномерный массив, заполненный случайными числами. 
 * Найдите сумму элементов, стоящих на нечётных позициях.*/
double[] CreateArray(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

double SumOfOddItems(double[] array)
{
    double sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}
Console.Write("Размер массива? : ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(n);
Console.WriteLine($"Получен массив : {string.Join(" ; ", array)}");
Console.Write($"Сумма элементов на нечетных позициях в массиве : {SumOfOddItems(array)}");
Console.ReadKey();


