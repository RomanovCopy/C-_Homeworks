Console.Clear();
Console.Write("Введите порядковый номер дня недели :");
int n = Convert.ToInt32(Console.ReadLine());
string day = n==6?"Суббота. Выходной!":n==7?"Воскресенье. Выходной!":"Работать!!!";
Console.WriteLine($"Сегодня: {day}");