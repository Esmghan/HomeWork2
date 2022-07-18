Console.WriteLine("Введите трехзначное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit = number/10 % 10;
Console.WriteLine ($"Вторая цифра трехзначного числа = {digit}");

