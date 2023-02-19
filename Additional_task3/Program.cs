
Console.Write( "Размерность массива : " );
int[] dim = Console.ReadLine().Split().Select( ( x ) => int.Parse( x ) ).ToArray();
int[,] array = CreateArray( dim[0], dim[1] );
PrintArray( array );
Console.ReadKey();






int[,] CreateArray( int lines, int columns )
{
    int[,] array = new int[lines, columns];
    int value = 0;
    int ik = 0;
    int jk = 0;
    int jkk = 0;
    for (int j = 0; j < columns; j++)
    {//заполнение до центральной диагонали
        ik = 0;
        jk = j;
        while (jk >= 0 && ik < lines)
        {
            array[ik, jk] = value;
            jk = jk - 1;
            ik = ik + 1;
            value++;
        }
    }
    for (int i = 1; i < lines; i++)
    {//заполнение после центральной диагонали
        jkk = jk;
        ik = i;
        jk = columns - 1;
        while (ik < lines && jk > jkk)
        {
            array[ik, jk] = value;
            jk = jk - 1;
            ik = ik + 1;
            value++;
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
