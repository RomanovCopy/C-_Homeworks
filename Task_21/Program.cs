/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.*/
double x1=0, x2=0;
double y1=0, y2=0;
double z1=0, z2=0;
/*Ввод можно сильно упростить если использовать приведение типов,
но мы этого еще не проходили, поэтому вот так...*/
Console.WriteLine("Введите координаты первой точки");
Console.Write("X : ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y : ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z : ");
z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X : ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y : ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Z : ");
z2 = Convert.ToDouble(Console.ReadLine());
double s=Math.Sqrt((Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)+ Math.Pow((z2 - z1),2)));
Console.WriteLine($"Расстояние между точками: \n({x1},{y1},{z1}) и ({x2},{y2},{z2}) равно - {s}");