/*По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.*/
Console.WriteLine("Введите целочисленныещ координаты( x,y через запятую) вершин треугольника.");
Console.Write("Вершина А (x,y): ");
int[] vertexA = Console.ReadLine().Split(',').Select((x) => Convert.ToInt32(x)).ToArray();
Console.Write("Вершина B (x,y): ");
int[] vertexB = Console.ReadLine().Split(',').Select((x) => Convert.ToInt32(x)).ToArray();
Console.Write("Вершина C (x,y): ");
int[] vertexC = Console.ReadLine().Split(',').Select((x) => Convert.ToInt32(x)).ToArray();
Console.WriteLine($"Площадь треугольника с вершинами в точках:");
Console.WriteLine($"A ( {vertexA[0]}, {vertexA[1]} )\n B ( {vertexB[0]}, {vertexB[1]} )\n  C ( {vertexC[0]}, {vertexC[1]} )");
Console.Write($"составляет {AreaOfTheTriangle(vertexA, vertexB, vertexC)}");
Console.ReadKey();

//площадь треугольника
double AreaOfTheTriangle(int[] vertex1, int[] vertex2, int[] vertex3)
{
    double[] lengths = TheLengthsOfTheSides(vertex1, vertex2, vertex3);//длины сторон
    double perimeter = lengths.Sum();//периметр
    //double area = Math.Sqrt(perimeter * (perimeter - lengths[0]) * (perimeter - lengths[1]) * (perimeter - lengths[2]));//площадь
    double area = (Math.Sqrt(lengths[0] + lengths[1] + lengths[2])*(lengths[1] + lengths[2] - lengths[0])*
        (lengths[0] + lengths[2] - lengths[1])*(lengths[0] + lengths[1] - lengths[2])) / 4;
    return area;
}

//длины сторон треугольника
double[] TheLengthsOfTheSides(int[] a, int[] b, int[] c)
{
    double[] lengths = new double[] {
            Math.Sqrt(Math.Pow(a[0]-b[0],2) + Math.Pow(a[1]-b[1],2)),//длина стороны AB
            Math.Sqrt(Math.Pow(a[0]-c[0],2) + Math.Pow(a[1]-c[1],2)),//длина стороны AC
            Math.Sqrt(Math.Pow(c[0]-b[0],2) + Math.Pow(c[1]-b[1],2)),//длина стороны CB
    };
    return lengths;
}


