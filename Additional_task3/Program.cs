
Console.Write( "Размерность массива : " );
int[] dim = Console.ReadLine().Split().Select( ( x ) => int.Parse( x ) ).ToArray();
int[,] array = CreateArray( dim[0], dim[1] );
PrintArray( array );
Console.ReadKey();





int[,] CreateArray( int lines, int columns )
{
    int value = 0;
    int dif = 2;
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength( 0 ); i++)
    { //начальные точки всех строк
        array[i, 0] = value;
        value += dif;
        dif++;
    }
    dif = 1;
    //заполняем строки до конца
    for (int i = 0; i < lines; i++)
    {
        dif = i + 1;
        value = array[i, 0];
        for (int j = 1; j < columns; j++)
        {
            value += dif;
            array[i, j] = value;
            dif++;
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
            Console.Write( $"{array[i, j]}\t" );
        }
        Console.WriteLine();
    }
}
