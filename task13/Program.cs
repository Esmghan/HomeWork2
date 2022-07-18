Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

if(number<100) 
{
    Console.WriteLine("Третьей цифры нет");
}
else{
    string figure=number.ToString();
    Console.WriteLine(figure[2]);
}
