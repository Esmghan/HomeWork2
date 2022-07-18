Console.Write("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>0 && number<8) {
    switch(number)
       { 
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2: 
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4: 
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6: 
            Console.WriteLine("Суббота - выходной");
            break;
        case 7:
            Console.WriteLine("Воскресенье - выходной");
            break;
       }
}
else {
    Console.WriteLine("Такого дня недели не существует");
}
