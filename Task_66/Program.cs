/*Задайте значения M и N. Напишите программу, которая найдёт сумму 
 * натуральных элементов в промежутке от M до N.*/
int Summ(int m, int n )
{
    if (m == n)
        return m;
    return m + Summ( m + 1, n );
}

Console.Write( "Два целых числа: " );
int[] array = Console.ReadLine().Split().Select( ( x ) => Convert.ToInt32( x ) ).ToArray();
int summ = array[0] == array[1] ? 0 : array[0] > array[1] ? Summ( array[1] + 1, array[0] - 1 ) : Summ( array[0] + 1, array[1] - 1 );
int summ1 = array[0] == array[1] ? array[0] + array[1] : array[0] > array[1] ? Summ( array[1], array[0] ) : Summ( array[0], array[1] );
Console.WriteLine ($"Сумма чисел в промежутке от {array[0]} до {array[1]} равна: " );
Console.WriteLine( $"Без учета первого и последнего числа - {summ}" );
Console.WriteLine( $"С учетом первого и последнего чисел - {summ1}" );
Console.ReadKey();