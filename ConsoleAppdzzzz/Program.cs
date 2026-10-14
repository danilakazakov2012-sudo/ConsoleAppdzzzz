Random random = new Random();
string playAgain;

do
{

    Console.WriteLine("угадай число за пожалуйстааа");

    int number = random.Next(1, 11);
    int attempts = 10;
    bool Win = false;

    Console.WriteLine("Я загадал число от 1 до 10. У тебя есть 10 попыток!");

    while (attempts > 0)
    {
        Console.Write($"Осталось попыток: {attempts}. Введи число: ");
        int user = Convert.ToInt32(Console.ReadLine());

        if (user == number)
        {
            Win = true;
            break;
        }
        else
        {
            Console.WriteLine("Лузер!");
        }

        attempts--;
    }

    if (Win)
    {
        Console.WriteLine("Красавчик! Ты выиграл!");
    }
    else
    {
        Console.WriteLine($"Ты проиграл. Было: {number}");
    }

    Console.Write("Хочешь сыграть еще раз? (да): ");
    playAgain = Console.ReadLine();

} while (playAgain == "да" || playAgain == "Да");

Console.WriteLine("энтер для выхоа");
Console.ReadLine();
