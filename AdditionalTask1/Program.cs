/*Дана строка, состоящая из N попарно различных символов. 
 * Требуется вывести все перестановки символов данной строки.*/
Console.Write("Введите строку : ");
char[] str = Console.ReadLine().ToArray();
for(int i=0; i < str.Length-1; i++)
{
    for (int j = i+1; j < str.Length; j++)
    {
        if (i != j)
            Console.WriteLine(string.Join(" ", search(i, j)));
    }
}
Console.ReadKey();

char[] search(int ch1, int ch2)
{
    char[] res = new char[str.Length];
    str.CopyTo(res, 0);
    char temp = res[ch1];
    res[ch1] = res[ch2];
    res[ch2] = temp;
    return res; 
}