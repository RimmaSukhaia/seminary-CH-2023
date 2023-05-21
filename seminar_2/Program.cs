/*
//напишите програму, которая выводит случайное число из отрезка [10; 99]
// и показывает наибольшую часть числа

int random = new Random().Next(10, 100);

System.Console.WriteLine(random);

int first = random/10;
int second = random%10;

if(first > second)
{
    System.Console.WriteLine(first);
}
else{
    System.Console.WriteLine(second);
}
*/

/*

//напишите программу. которая выводит на экран случайное трехзначное число
// и удаляет вторую цифру этого числа

int random = new Random().Next(100, 1000);

System.Console.WriteLine(random);

int first = random/100;
int three = random%10;

int num = first*10 + three;
System.Console.WriteLine(num);

System.Console.WriteLine("" + first + three);

*/

/*
//напишите программу, которая будет принимать на вход 2 числа и выводить на экран
//является ли второе число кратным первому или же выводить остаток

System.Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

int ost = num1%num2;
if(ost == 0)
{
    System.Console.WriteLine($"число {num2} кратно числу {num1}");
}
else System.Console.WriteLine($"число {num2} не кратно числу {num1}, остаток равен {ost}");
*/

/*
//напишите программу которая принимает число и проверяет кратно ли оно числу 7 и 23 одновременно
System.Console.WriteLine("Введите делимое число: ");
int num1 = 0;
while(!int.TryParse(Console.ReadLine(), out num1)){System.Console.WriteLine("это не число");}


System.Console.WriteLine("Введите делитель 1: ");
int num2 = 0;
while(!int.TryParse(Console.ReadLine(), out num2)){System.Console.WriteLine("это не число");}


System.Console.WriteLine("Введите делитель 2: ");
int num3 = 0;
while(!int.TryParse(Console.ReadLine(), out num3)){System.Console.WriteLine("это не число");}



if(num1%num2 == 0 & num1%num3 ==0)
{
    System.Console.WriteLine($"число {num1} кратно {num2} и {num3}");
}
else System.Console.WriteLine($"число {num1} не кратно одному из чисел");

*/

//напишите программу, которая принимает 2 числа и проверяет 
//является ли одно число квадратом другого

System.Console.WriteLine("введите число 1: ");
int num1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("введите число 2: ");
int num2 = int.Parse(Console.ReadLine());


if(Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1)
{
    System.Console.WriteLine($"да");
}
else System.Console.WriteLine("не является корнем");