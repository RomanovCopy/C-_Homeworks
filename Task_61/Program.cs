/*Вывести первые N строк треугольника Паскаля. 
 * Сделать вывод в виде равнобедренного треугольника*/
Console.Write( "Колличество строк :" );
int n = Convert.ToInt32( Console.ReadLine() );
PrintTriangle( PascalTriangle( n ) );
Console.ReadKey();

//создание двуменого массива с данными
int[,] PascalTriangle(int n )
{
    int [,]T = new int[n , n * 2];
    T[0, n ] = 1;
    for(int i = 1; i < T.GetLength( 0 ); i++)
    {
        for (int j = 0; j < T.GetLength( 1 ); j++)
        {
            int l = j - 1 > 0 ? j - 1 : 0;
            int p = j + 1 < T.GetLength( 1 ) ? j + 1 : 0;
            T[i, j] = T[i - 1, l] + T[i - 1, p];
        }
    }
    return T;
}
//вывод массива в виде треугольника(условно)
void PrintTriangle( int[,] T )
{
    for (int i = 0; i < T.GetLength( 0 ); i++)
    {
        string l = "";
        for (int j = 0; j < T.GetLength( 1 ); j++)
        {
            int s = T[i, j];
            l = $"{l}{(s > 0 ? s : " ")}";
        }
        Console.WriteLine( $"{l}\t" );
    }
}
