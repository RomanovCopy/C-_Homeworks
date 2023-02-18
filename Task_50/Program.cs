/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
 * и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int[,] array = CreateArray( 5, 5 );
PrintArray( array );
Console.Write( "Укажите позицию начиная с 1 : " );
int[] dim = Console.ReadLine().Split().Select( ( x ) => int.Parse( x ) ).ToArray();
FindArray( dim[0] - 1, dim[1] - 1, array );
Console.ReadKey();





int[,]CreateArray(int lines, int columns )
{
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {
        for (int j = 0; j < array.GetLength( 1 ); j++)
        {
            array[i, j] = new Random().Next(0,100);
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
void FindArray(int line, int column, int[,] array )
{
    if (line > 0 && line < array.GetLength( 0 ) && column > 0 && column < array.GetLength( 1 ))
        Console.WriteLine( $"Выбран элемент со значением: {array[line, column]}" );
    else
        Console.WriteLine( $"Элемент не существует" );
}