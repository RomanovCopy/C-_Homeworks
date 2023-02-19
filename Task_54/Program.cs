/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
 * элементы каждой строки двумерного массива.*/
Console.Write( "Введите размерность массива: " );
int[] dim = Console.ReadLine().Split().Select( x => int.Parse( x ) ).ToArray();
int[,] array = CreateArray( dim[0], dim[1] );
Console.WriteLine( "Исходный массив : " );
PrintMatrix( array );
array = DescendingLineByLine( array );
Console.WriteLine( "Отсортированный построчно массив:" );
PrintMatrix( array );
Console.ReadKey();

//генерация случайного массива
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
//печать
void PrintMatrix( int[,] matrix )
{
    for (int i = 0; i < matrix.GetLength( 0 ); i++)
    {
        for (int j = 0; j < matrix.GetLength( 1 ); j++)
            Console.Write( $"{matrix[i, j]} \t" );
        Console.WriteLine();
    }
}
//сортировка
int[,] DescendingLineByLine( int[,] array )
{
    int max = 0;//позиция текущего максимального элемента в строке
    for (int i = 0; i < array.GetLength( 0 ); i++)
    {//перебор строк
        for (int ik = 0; ik < array.GetLength( 1 ); ik++)
        {//индекс для перестановки
            max = ik;
            for (int j = array.GetLength( 1 ) - 1; j >= ik; j--)
            {//масимальное значение поиск
                if (array[i,j] > array[i, max])
                {
                    max = j;
                }
                if (j == ik)
                {//перестановка
                    int temp = array[i, ik];
                    array[i, ik] = array[i, max];
                    array[i, max] = temp;
                }
            }

        }
    }
    return array;
}
