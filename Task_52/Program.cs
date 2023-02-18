/*Задайте двумерный массив из целых чисел. 
 * Найдите среднее арифметическое элементов в каждом столбце.*/
int[,] array = CreateArray( 5, 5 );
double sum = 0;
PrintArray( array );
double[] average = new double[array.GetLength( 1 )];
for (int j = 0; j < array.GetLength( 1 ); j++)
{
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {
        sum += array[i, j];
    }
    average[j] = sum / array.GetLength( 0 );
    sum = 0;
}
Console.WriteLine( $"Среднее арифметическое по колонкам : {string.Join( " ; ", average )}" );
Console.ReadKey();





int[,] CreateArray( int lines, int columns )
{
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {
        for (int j = 0; j < array.GetLength( 1 ); j++)
        {
            array[i, j] = new Random().Next( 0, 100 );
        }
    }
    return array;
}
void PrintArray( int[,] array )
{
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {
        for (int j = 0; j < array.GetLength( 1 ); j++)
        {
            Console.Write( $"{array[i, j].ToString( "##.##" )}\t" );
        }
        Console.WriteLine();
    }
}
