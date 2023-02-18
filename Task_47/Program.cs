/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/
Console.Write( "Размерность двумерного массива : " );
int[] dim = Console.ReadLine().Split().Select( ( x ) => int.Parse( x ) ).ToArray();
double[,] array = new double[dim[0], dim[1]];
for(int i = 0; i < array.GetLength( 0 ); i++)
{
    for(int j = 0; j < array.GetLength( 1 ); j++)
    {
        array[i, j] = new Random().NextDouble() * 100;
    }
}
for (int i = 0; i < array.GetLength( 0 ); i++)
{
    for (int j = 0; j < array.GetLength( 1 ); j++)
    {
        Console.Write( $"{ array[i, j].ToString("##.##")}\t");
    }
    Console.WriteLine();
}
Console.ReadKey();



