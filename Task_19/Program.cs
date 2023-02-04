/*Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом*/

int str = 1;//вводимое число
int log = 0;//разрядность введеного числа
int n = 5;//необходимая разрядность вводимого числа

while (log != n - 1)
{/*получение числа нужной разрядности*/
    Console.Write("Введите любое пятизначное число: ");
    str = Convert.ToInt32(Console.ReadLine());
    log = Convert.ToInt32(Math.Log(str, 10));
    Console.Clear();
}
string line = Convert.ToString(str);
for (int i = 0; i < log / 2; i++)
{
    if (line[i] != line[log - i])
    {
        Console.WriteLine($"Число {str} не является палиндромом");
        return;
    }
}
Console.WriteLine($"Число {str} является палиндромом");

