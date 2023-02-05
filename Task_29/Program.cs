//программа построена на условии, что вводимый массив
//отсортирован в порядке убывания
//нумерация позиций в шеренге для удобства начинается с единицы
Console.Clear();
Console.Write("Введите колличество учеников :");
int N = Convert.ToInt32(Console.ReadLine());
double[] A = new double[N];
for (int i = 0; i < A.Length; i++)
{//ввод данных
    Console.Clear();
    Console.WriteLine($"Всего учеников: {N}");
    Console.Write($"Рост ученика {i + 1} : ");
    A[i] = Convert.ToDouble(Console.ReadLine());
}
//вывод шеренги до появления нового ученика
Console.WriteLine($"Шеренга до появления нового ученика:");
Console.WriteLine(string.Join(" : ", A));
Console.Write($"Рост нового ученика: ");
double a = Convert.ToDouble(Console.ReadLine());
int ResultPosition = 0;//позиция нового ученика
//т.к размер массива Array нельзя изменить
//копируем данные в новый увеличенный массив
double[] A1 = new double[N + 1];
for (int i = 0; i < A.Length; i++)
{
    A1[i] = A[i];
}
//ищем и устанавливаем нового ученика в его пизицию в шеренге
for (int i = A1.Length - 1; i >= 0; i--)
{
    if (a <= A1[i])
    {//рост этого ученика равен или больше роста нового ученика
        //сдвигаем учеников вправо на одну позицию,
        //чтобы на освободившуюся поставить нового ученика
        for (int j = A1.Length - 1; j > i + 1; j--)
        {
            double temp = A1[j];
            A1[j] = A1[j - 1];
            A1[j - 1] = temp;
        }
        ResultPosition = i + 1;//получаем конечную позицию нового ученика
                               //пока нумерация с нуля
        break;//выходим из цикла
    }
    else
    {
        if (i == 0)
        {//если новый ученик выше всех
            for (int j = A1.Length - 1; j > 0; j--)
            {//сдвиг на одну позицию вправо начиная с позиции 0
                double temp = A1[j];
                A1[j] = A1[j - 1];
                A1[j - 1] = temp;
            }
            ResultPosition = i;//получаем конечную позицию нового ученика
                               //пока нумерация с нуля
            break;//выходим из цикла
        }
    }
}
//устанавливаем нового ученика в его позицию в шеренге для удобства отображаемая нумерация с единицы
Console.WriteLine($"Новый ученик займет позицию {ResultPosition + 1} в шеренге");
A1[ResultPosition] = a;
//вывод шеренги после появления нового ученика
Console.WriteLine($"Шеренга после появления нового ученика:");
Console.WriteLine(string.Join(" : ", A1));



