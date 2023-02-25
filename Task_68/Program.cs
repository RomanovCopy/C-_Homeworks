/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 * Даны два неотрицательных числа m и n.*/
int Akkerman( int m, int n )
{
    if (m == 0)
        return n + 1;
    else if ((m != 0) && (n == 0))
        return Akkerman( m - 1, 1 );
    else
        return Akkerman( m - 1, Akkerman( m, n - 1 ) );
}

Console.Write( "Введите через пробел два положительных числа :" );
int[] array = Console.ReadLine().Split().Select( ( x ) => Convert.ToInt32( x ) ).ToArray();
Console.Write( $"Результат вычисления функции Аккермана: {Akkerman( array[0], array[1] )}" );

Console.ReadKey();