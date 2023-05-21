/*
// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

int Cifra(int a)
{
    int n = a/10;
    n = n%10;
    return n;
}

System.Console.WriteLine("введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

if(num > 999 || num < 100)
{
    System.Console.WriteLine("неверно введено число");
}

else Console.WriteLine(Cifra(num));

*/

/*
// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

int ThreeNum(int a)
{
    while(a > 999)
    {
        a= a/10;
    }
    int num3 = a%10;
    return num3;
}

System.Console.WriteLine("введите число: ");
int num = int.Parse(Console.ReadLine());
if(num <100)
{
    System.Console.WriteLine("третей цифры нет");
}
else System.Console.WriteLine($"третья цифра {ThreeNum(num)}");

*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.


System.Console.WriteLine("Ввудите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
if(day >0 && day <8)
{
    if(day < 6)
    {
        System.Console.WriteLine("no");
    }
    else System.Console.WriteLine("yes");
}
else System.Console.WriteLine("неверно введено число");