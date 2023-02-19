/*Задайте прямоугольный двумерный массив. Напишите программу, 
 * которая будет находить строку с наименьшей суммой элементов.*/
Console.Write( "Введите размерность массива: " );
int dim = Convert.ToInt32( Console.ReadLine() );
int[,] array = CreateArray( dim, dim );
Console.WriteLine( "Исходный массив : " );
PrintMatrix( array );
Console.WriteLine( "Строка с наименьшей суммой элементов: " );
for (int i = 0; i < array.GetLength( 1 ); i++)
    Console.Write( $" {array[LineMinValue( array ), i]} " );
Console.ReadKey();

//индекс строки с миниальной суммой значений
int LineMinValue( int[,] array )
{
    int min = 0;//индекс минимальной строки
    int minvalue = 0;//сумма значений строки с индексом min
    int temp = 0;//сумма значений текущей строки
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            temp+= array[i, j];
        }
        if (i == 0)
        {
            minvalue = temp;
        }
        else
        {
            if (temp < minvalue)
            {
                min = i;
                minvalue = temp;
            }
        }
        temp = 0;
    }
    return min;
}
//генерация случайного массива с заданной размерностью
int[,] CreateArray( int lines, int columns )
{
    int[,] array = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next( 0, 100 );
        }
    }
    return array;
}
//вывод в консоль
void PrintMatrix( int[,] matrix )
{
    for (int i = 0; i < matrix.GetLength( 0 ); i++)
    {
        for (int j = 0; j < matrix.GetLength( 1 ); j++)
            Console.Write( $"{matrix[i, j]} \t" );
        Console.WriteLine();
    }
}
