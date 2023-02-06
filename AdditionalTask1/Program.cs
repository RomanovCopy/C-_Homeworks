/*Дана последовательность из N целых чисел и число K. 
 * Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо,
 * если K – положительное и влево, если отрицательное.*/
Console.Write("Введите длину последовательности целых чисел :");
int N = Convert.ToInt32(Console.ReadLine());//длина последовательности
int[] array = new int[N];//массив для хранения последовательности
//Ввод последовательности
for (int i = 0; i < N; i++)
{
    Console.Clear();
    Console.Write($"Длина последовательности: {N}\nВведено : {i}\n");
    Console.Write("Очередное целое число : ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
//вывод последовательности после ввода
Console.Clear();
Console.Write($"Введена последовательность :\n {string.Join(" ; ", array)}\n");
//ввод сдвига
Console.WriteLine("Введите величину сдвига : ");
int K = Convert.ToInt32(Console.ReadLine());//величина и направление сдвига
//реализация сдвига
if (K > 0)
{
    int temp = 0;
    for (int i = 0; i < K; i++)
    {
        temp = array[array.Length - 1];
        for (int j = array.Length-1; j > 0; j--)
        {
            array[j] = array[j - 1];
        }
        array[0] = temp;
    }
}
else
{
    int temp = 0;
    for (int i = 0; i > K; i--)
    {
        temp = array[0];
        for (int j = 0 ; j < array.Length-1; j++)
        {
            array[j] = array[j + 1];
        }
        array[array.Length-1] = temp;
    }
}
Console.Write($"Последовательность после сдвига :\n {string.Join(" ; ", array)}\n");


