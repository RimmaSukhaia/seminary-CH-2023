/*
Console.WriteLine("введите число: ");

string s = Console.ReadLine();
int i;
if (int.TryParse(s,out i))
{
    Console.WriteLine($"квадрат числа {i} = {Math.Pow(i,2)}");
}
else System.Console.WriteLine("Упс!");
*/

/*
//Написать програму, которая принимает на вход два числа и проверяет
//является ли второе число квадратом первого

System.Console.WriteLine("Введите число, возводимое в квадрат: ");

string s =Console.ReadLine();
int i = int.Parse(s);

System.Console.WriteLine("Введите чиcло, которое является квадратом первого: ");

string k =Console.ReadLine();
int j = int.Parse(k);

if(j == Math.Pow(i,2))
{
    System.Console.WriteLine("да");
}
else System.Console.WriteLine("нет");
*/

/*
//Напишите програму, которая будет выдавать название дня недели по заданому номеру

System.Console.WriteLine("Введите номер дня недели от 1 до 7: ");
string s = Console.ReadLine();
int i = int.Parse(s);

if (i == 1)
{
    System.Console.WriteLine("понедельник");
}
else if (i == 2)
{
    System.Console.WriteLine("вторник");
}
else if (i == 3)
{
    System.Console.WriteLine("среда");
}
else if (i ==4)
{
    System.Console.WriteLine("четверг");
}
else if (i ==5)
{
    System.Console.WriteLine("пятница");
}
else if (i ==6)
{
    System.Console.WriteLine("суббота");
}
else if (i ==7)
{
    System.Console.WriteLine("воскресенье");
}
else System.Console.WriteLine("недопустимое значение");
*/

/*
//Напишите програм, которая принимае на вход число (N) и выдает все целые числа от -N до N

System.Console.WriteLine("Введите число: ");
int s = int.Parse(Console.ReadLine());

for(int i = -s; i <= s; i++)
    Console.Write(i + ", ");
*/

//напишите програму, которая принимает на вход трехзначное число, 
//и на выходе покзывает последнюю цифру

System.Console.WriteLine("Введите трехзнвчное число: ");
int s = int.Parse(Console.ReadLine());
if (s >= 100 && s < 1000)
{
    System.Console.WriteLine($"последняя цифра равна {s%10}");
}
else System.Console.WriteLine("заданное число не 3х значное");