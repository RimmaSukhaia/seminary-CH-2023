/*
//Напишите прогамму, которая на вход принимает два числа и выдает, большее число
Console.Write("Введите первое число: ");

string s = Console.ReadLine();
int num1 = int.Parse(s);

Console.Write("Введите второе число: ");

string t = Console.ReadLine();
int num2 = int.Parse(t);

if(num1 > num2)
{
    System.Console.WriteLine($"Наибольшее число:  {num1}");
}
else
{
    System.Console.WriteLine($"Наибольшее число: - {num2}");
}
*/

/*
//Напишите программу, которая принимает на вход три числа и выдает макстмальное из этих трех

Console.Write("Введите первое число: ");

string s = Console.ReadLine();
int num1 = int.Parse(s);

Console.Write("Введите второе число: ");

string t = Console.ReadLine();
int num2 = int.Parse(t);

Console.Write("Введите третье число: ");

string k = Console.ReadLine();
int num3 = int.Parse(k);

if (num1 > num2)
{
    if(num1 > num3)
    {
        System.Console.WriteLine($"Наибольшее число: {num1}");
    }
    else System.Console.WriteLine($"Наибольшее число: {num3}");
}
else
{
    if(num2 > num3)
    {
        System.Console.WriteLine($"Наибольшее число: {num2}");
    }
    else System.Console.WriteLine($"Наибольшее число: {num3}");
}

*/

/*
//Напишите программу, которая принимает на вход число и выдает, является ли число четным

Console.Write("Введите число: ");

int i = int.Parse(Console.ReadLine());
if (i%2 == 0)
{
    Console.WriteLine($"Число - четное!");
}
else Console.WriteLine($"Число - нечетное");

//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все четные числа от 1 до N
*/

//Напишите програму, которая на вход принимает число N и выдает числа от 1 до N

System.Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine());
if (i > 0)
{
    for(int a = 1; a <= i; a++)
        System.Console.Write(a + ", ");
}
else System.Console.WriteLine("некоректное число");