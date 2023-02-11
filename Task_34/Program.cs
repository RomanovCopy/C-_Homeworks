/*Задайте массив заполненный случайными положительными трёхзначными числами. 
 * Напишите программу, которая покажет количество чётных чисел в массиве.*/
Console.Write("Колличество элементов в массиве : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(n);
Console.WriteLine(string.Join(" ; ", array));
Console.Write($"Колличество четных чисел : {NumberOfPositiveNumbers(array)}");
Console.ReadKey();


int[] CreateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

int NumberOfPositiveNumbers(int[] array)
{
    int summ = 0;
    foreach (int number in array)
        summ += number % 2 == 0 ? 1 : 0;
    return summ;
}