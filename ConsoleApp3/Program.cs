using System.Runtime.InteropServices;
using System.Threading.Channels;



Console.WriteLine("1. Сложить 2 числа\n2. Вычесть первое из второго\n3.Перемножить два числа\n4.Разделить первое на второе\n5.Возвести в степень N первое число\n6.Найти квадратный корень из числа\n7.Найти 1 процент от числа\n8.Найти факториал из числа\n9.Выйти из программы");
Console.WriteLine("Введите число действия");
string p = Console.ReadLine();

if (p == "9")
{
    Console.WriteLine("Вы вышли из программы");
    return;
}
Console.WriteLine("Введите первое число");
string x = Console.ReadLine();
int inputx = Convert.ToInt32(x);


if (p == "1") 
{
    Console.WriteLine("Введите второе число");
    string y = Console.ReadLine();
    int inputy = Convert.ToInt32(y);

    Console.WriteLine("Ващ результат ");
    Console.Write(x + y);
}
if (p == "2")
    
{
    Console.WriteLine("Введите второе число");
    string y = Console.ReadLine();
    int inputy = Convert.ToInt32(y);

    Console.WriteLine("Ващ результат ");
    Console.Write(inputx - inputy);
}

if (p == "3")
{
    Console.WriteLine("Введите второе число");
    string y = Console.ReadLine();
    int inputy = Convert.ToInt32(y);

    Console.WriteLine("Ващ результат ");
    Console.Write(inputx * inputy);
}

if (p == "4")
{
    Console.WriteLine("Введите второе число");
    string y = Console.ReadLine();
    int inputy = Convert.ToInt32(y);

    Console.WriteLine("Ващ результат ");
    Console.Write(inputx / inputy);
}

if (p == "5")
{
   

    Console.WriteLine("Введите степень");
  string n =  Console.ReadLine();
  int inputn = Convert.ToInt32(n);
  Console.WriteLine("Ваш резултат ");
  Console.WriteLine(Math.Pow(inputx,inputn));

}

if (p == "6")
{
    Console.WriteLine("Введите второе число");
    string y = Console.ReadLine();
    int inputy = Convert.ToInt32(y);
    Console.WriteLine("Результат: " + (Math.Sqrt(inputx)), (Math.Sqrt(inputy)));
}
if (p == "7")
{
    Console.WriteLine("Введите второе число");
    string y = Console.ReadLine();
    int inputy = Convert.ToInt32(y);
    Console.WriteLine("Ваш результат ");
    Console.WriteLine(inputx * 0.01);
    Console.WriteLine(inputy * 0.01);
}

if (p == "8")
{
    Console.WriteLine("Введите второе число");
    string y = Console.ReadLine();
    int inputy = Convert.ToInt32(y);
    Console.WriteLine("Результат: ");
    Console.WriteLine();
    int g = 1;
    for (int i = 1; i <= inputy; i++)
    {
        g = g * i;
    }
    Console.WriteLine("Результат: ");
    Console.WriteLine(g);
}
