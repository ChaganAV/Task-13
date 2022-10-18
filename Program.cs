// Вывод третьей цифры заданного числа
int max = 1000000000;
int num = ReadInt($"Введите любое число меньше {max}: ");
if (num > max)
{
    num = ReadInt($"Вы ввели слишком большое число, попробуйте еще раз");
}
while(num/max == 0)
{
    max = max/10;
}

if (num > 99)
{
    int second = num/(max/10)*10;
    int temp = num/(max/100);
    int three = temp-second;
    Console.WriteLine($"{second}");
    Console.WriteLine($"В числе {num} третья цифра: {three}");
}
else
{
    Console.WriteLine($"Sorry, в числе {num} третьей цифры нет!");
}
// Metods
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}