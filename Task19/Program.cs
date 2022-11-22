Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number.ToString()[0] == number.ToString()[4] && number.ToString()[1] == number.ToString()[3])
    {
        Console.WriteLine("Да");
    }
else
    {
        Console.WriteLine("Нет");
    }