Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 9999 && number < 100000) || (number < -9999 && number > -100000))
    {
        if ((number / 10000 == number % 10) && (number / 1000 % 10 == number /10 % 10))
            Console.WriteLine("Число полиндром");
        else 
            Console.WriteLine("Чиcло не полиндром");
    }
else 
    Console.WriteLine("Число не пятизначное");
