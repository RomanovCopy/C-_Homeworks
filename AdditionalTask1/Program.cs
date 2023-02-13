/*Дана строка, состоящая из N попарно различных символов. 
 * Требуется вывести все перестановки символов данной строки.*/
Console.Write("Введите строку : ");
char[] str = Console.ReadLine().ToArray();//строка преобразованная в массив символов
if(str.Length<2)
{
    Console.WriteLine("Короткая строка. Нет вариантов перебора.");
    return;
}
int count = 1;//счетчик комбинаций
print(str, count);//вывод исходного варианта
int length = str.Length;//длина строки
char[] res = new char[length];//массив для временного хранения очередной комбинации
recursion(0, 0);//начало обработки
Console.ReadKey();//удержание консоли

//рекурсия( метод вызывает сам себя )
void recursion(int p1, int p2)
{

    if (p1 != p2)//фильтр, нет смысла менять символ сам на себя
        print(search(p1, p2), count);
    if (p1 == length - 1 && p2==length-1) return;//выход из рекурсии
    if (p2 < length - 1)//перебор индексов элементов в массиве для перестановки
        p2++;
    else
    {
        p1++;
        p2 = p1;//не начинаем с нуля, т.к. будет повтор комбинаций
    }
    recursion(p1, p2);
}

//вывод строки на консоль
void print(char[] array, int count)
{
    Console.WriteLine($"{count}  {string.Join(' ', array)}");
}

//копирование и перестановка элементов в массиве
char[] search(int ch1, int ch2)
{
    str.CopyTo(res, 0);
    char temp = res[ch1];
    res[ch1] = res[ch2];
    res[ch2] = temp;
    count++;
    return res;
}