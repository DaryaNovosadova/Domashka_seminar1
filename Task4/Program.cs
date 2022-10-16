Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int [] number = {numberA, numberB, numberC};
int size = 3;
int index = 0;
int max = number[0];
while(index < size)
{
    if(number[index] > max)
    {
        max = number[index];
    }
    index++;
}
Console.WriteLine($"MAX = {max}");