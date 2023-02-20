/*Напишите программу, которая заполнит спирально массив 4 на 4

/*заполняет по спирали любой двумерный массив */
Console.Write( "Размерность двумерного массива через пробел(любая): " );
int value = 0;
int[] dim = Console.ReadLine().Split().Select( ( x ) => Convert.ToInt32( x ) ).ToArray();
int[] point = new int[] { 0, 0 };
int[,] array = new int[dim[0], dim[1]];
PrintArray( HelicalFilling( array ) );
Console.ReadKey();


//основной блок
int[,] HelicalFilling( int[,] array )
{
    int travel = 90;
    SetValue( );
    while (travel >= 0)
    {
        if (travel == 90)
        {//движение направо
            while (CanRight())
            {
                    point[1] = point[1] + 1;
                SetValue( );
            }
            travel = 180;
        }
        else if (travel == 180)
        {//движение вниз
            while (CanDown())
            {
                point[0] = point[0] + 1;
                SetValue( );
            }
            travel = 270;
        }
        else if (travel == 270)
        {//движение влево
            while (CanLeft())
            {
                point[1] = point[1] - 1;
                SetValue( );
            }
            travel = 0;
        }
        else if (travel == 0)
        {//движение вверх
            while (CanUp())
            {
                point[0] = point[0] - 1;
                SetValue( );
            }
            travel = 90;
        }
        travel = value >=( dim[0] * dim[1]) ? -1 : travel;
    }
    return array;
}
//вывод в консоль
void PrintArray( int[,] array )
{
    for(int i=0; i < array.GetLength( 0 ); i++)
    {
        for (int j = 0; j < array.GetLength( 1 ); j++)
        {
            Console.Write( $"{array[i, j]}\t" );
        }
        Console.WriteLine();
    }
}
//разрешение на ход влево
bool CanLeft()
{
    return point[1] - 1 >= 0 && array[point[0], point[1] - 1] == 0;
}
//разрешение на ход вправо
bool CanRight()
{
    return point[1] + 1 < array.GetLength( 1 ) && array[point[0], point[1] + 1] == 0;
}
//разрешение на ход вверх
bool CanUp()
{
    return point[0] - 1 >= 0 && array[point[0]-1, point[1]] == 0;
}
//разрешение на ход вниз
bool CanDown()
{
    return point[0] + 1 < array.GetLength( 0 ) && array[point[0] + 1, point[1]] == 0;
}
//установка значения ячейки
void SetValue( )
{
    value += 1;
    array[point[0], point[1]] = value;
}
