// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
int temp = a;
int b = 0; 
while (temp != 0)
{
    b = b * 10 + temp % 10;
    temp /= 10;
}
if (a == b) Console.WriteLine("yes");
else Console.WriteLine("no");