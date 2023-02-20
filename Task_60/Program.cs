/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
 * Напишите программу, которая будет построчно выводить массив, 
 * добавляя индексы каждого элемента.*/
Console.Write( "Размерность трехмерного массива: " );
int[] dim = Console.ReadLine().Split().Select( ( x ) => Convert.ToInt32( x ) ).ToArray();
int[,,] array = CreateArray( dim );
PrintArrayDim3( array );
Console.ReadKey();


//создание и заполнение трехмерного массива
int[,,] CreateArray( int[] dim )
{
    int[,,] array = new int[dim[0], dim[1], dim[2]];
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {
        for (int j = 0; j < array.GetLength( 1 ); j++)
        {
            for (int k = 0; k < array.GetLength( 2 ); k++)
            {
                array[i, j, k] = new Random().Next( 0, 100 );
            }
        }
    }
    return array;
}
//построчный вывод трехмерного массива с индексами
void PrintArrayDim3( int[,,] array )
{
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {
        for (int j = 0; j < array.GetLength( 1 ); j++)
        {
            for (int k = 0; k < array.GetLength( 2 ); k++)
            {
                Console.WriteLine( $" {array[i, j, k]}\t({i},{j},{k})\t" );
            }
        }
    }
}