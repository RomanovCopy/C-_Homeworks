/*Задайте массив вещественных(дробных) чисел. 
 * Найдите разницу между максимальным и минимальным элементов массива.*/
double[] CreateArray(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble()*100;
    return array;
}
double Diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach(double number in array)
    {
        min = number < min ? number : min;
        max = number > max ? number : max;
    }
    return max - min;
}
Console.Write("Размер массива? : ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(n);
Console.WriteLine($"Получен массив : {string.Join(" ; ", array)}");

Console.Write($"Разница между максимальным и минимальным значениями массива : {Diff(array)}");
Console.ReadKey();

