Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if(numberB < max)
{
    Console.WriteLine($"MAX = {numberA}");
    Console.WriteLine($"MIN = {numberB}");
}
else
{
    Console.WriteLine($"MAX = {numberB}");
    Console.WriteLine($"MIN = {numberA}");
}