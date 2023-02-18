int[,] array = CreateArray( 5, 5 );
PrintArray( array );
array = Tran( array );
Console.WriteLine( "Транспорированный относительно горизонтали массив :" );
PrintArray( array );
Console.ReadKey();

//создание двумерного массива
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
//вывод двумерного массива
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
//транспорирование двумерного массива
int[,] Tran( int[,] array )
{
    int tmp;
    int last = array.GetLength(0)-1;
    for (int i = 0; i < array.GetLength(0)/2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmp = array[i, j];
            array[i, j] = array[last-i, j];
            array[last - i, j] = tmp;
        }
    }
    return array;
}