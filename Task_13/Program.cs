Console.Clear();
Console.Write("Введите любое целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n3=n;
if(n<100)
{
   Console.WriteLine($"В числе {n} третьей цифры нет");
   return;
}
else
   {//делим число на десять пока оно не будет состоять  из трех разрядов
      while(n3>999)
          n3=n3/10;
      n3=n3%10;//получаем значение последнего(третьего) разряда
   }
Console.Write($"В числе {n} третьей цифрой является: {n3}");