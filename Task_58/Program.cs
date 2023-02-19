/*Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/
int[] dimA;
int[] dimB;
do
{//проверка на возможность получения произведения матриц
    Console.Clear();
    Console.Write( "Размерность матрицы А: " );
    dimA = Console.ReadLine().Split().Select( ( x ) => int.Parse( x ) ).ToArray();
    Console.Write( "Размерность матрицы B: " );
    dimB = Console.ReadLine().Split().Select( ( x ) => int.Parse( x ) ).ToArray();
} while (dimA[0] == dimB[1] && dimA[1] == dimB[0]);

int[,] matrixA = CreateArray( dimA[0], dimA[1] );
int[,] matrixB = CreateArray( dimB[0], dimB[1] );
Console.WriteLine( "Сгенерирована матрица А : " );
PrintMatrix( matrixA );
Console.WriteLine( "------------" );
Console.WriteLine( "Сгенерирована матрица B : " );
PrintMatrix( matrixB );
Console.WriteLine( "------------" );
Console.WriteLine( "Произведение матриц А и В :" );
PrintMatrix( MatrixMultiplication( matrixA, matrixB ) );
Console.ReadKey();

int[,] MatrixMultiplication( int[,]a, int[,]b )
{
    int[,] r = new int[a.GetLength( 0 ), b.GetLength( 1 )];
    for (int i = 0; i < a.GetLength( 0 ); i++)
    {
        for (int j = 0; j < b.GetLength( 1 ); j++)
        {
            for (int k = 0; k < b.GetLength( 0 ); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

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
void PrintMatrix( int[,] matrix )
{
    for (int i = 0; i < matrix.GetLength( 0 ); i++)
    {
        for (int j = 0; j < matrix.GetLength( 1 ); j++)
            Console.Write( $"{matrix[i, j]}\t " );
        Console.WriteLine();
    }
}
