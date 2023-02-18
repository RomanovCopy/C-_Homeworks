Console.Write( "Размер изображения : " );
int[] dim = Console.ReadLine().Split().Select( ( x ) => int.Parse( x ) ).ToArray();
char[,] array = CreateArray( dim[0], dim[1] );
Console.WriteLine( "Первичный массив : " );
PrintArray( array );
char[,] array2 = CreateArray( dim[0], dim[1] );
Console.WriteLine( "Вторичный массив : " );
PrintArray( array );
Console.Write( $"Не совпадает {contains( array, array2 )} пикселей." );
Console.ReadKey();




int contains( char[,]a, char[,] b )
{
    int count = 0;
    for (int i = 0; i < a.GetLength( 0 ); i++)
    {
        for (int j = 0; j < a.GetLength( 1 ); j++)
        {
            count += a[i, j] == b[i, j] ? 1 : 0;
        }
    }
    return count;
}
char[,] CreateArray( int lines, int columns )
{
    char[,] array = new char[lines, columns];
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {
        for (int j = 0; j < array.GetLength( 1 ); j++)
        {
            array[i, j] = new Random().Next( 0, 2 ) == 1 ? 'B' : 'W';
        }
    }
    return array;
}
void PrintArray( char[,] array )
{
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {
        for (int j = 0; j < array.GetLength( 1 ); j++)
        {
            Console.Write( $"{array[i, j]}\t" );
        }
        Console.WriteLine();
    }
}
