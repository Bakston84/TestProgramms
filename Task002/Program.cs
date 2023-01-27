int number = 0;
int userNumber = 0; //стартовое число очков игрока
int npsNumber = 0;  //стартовое число очков NPS
int length = 4; //кол-во ходов (-1)
int userIndex = 0;
int npsIndex = 0;

Console.WriteLine("Игра: Двадцать одно");
String userName = InputString("Давай знакомиться!? Как тебя зовут");
System.Console.WriteLine($"Привет, {userName}!");
System.Console.WriteLine($"{userName}, предлагаю сыграть в игру - Двадцать одно?");
String select = InputString("Ты готов (Да/Нет)");
if (select.ToLower() == "да")
{
    Game();
}
return;

string InputString(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = System.Console.ReadLine();
    string? result = Convert.ToString(inputValue);
    return result;
}

int Randome(int number)
{
    Random rnd = new Random();
    number = rnd.Next(1, 11);
    return number;
}

int NPSGame(int npsNumber)
{
    System.Console.WriteLine("Мой ход");
    while (npsNumber <= 16)
    {
        npsNumber = npsNumber + Randome(number);
        if (npsNumber > 21)
        {
            return npsNumber;
        }
    }
    return npsNumber;
}

void Game()
{
    System.Console.WriteLine($"{userName}, начнём игру! У вас 3 попытки.");
    for (int i = 1; i < length; i++)    //цикл хода
    {
        System.Console.WriteLine($"Ход {i}");   //показываем ход
        userNumber = Randome(number) + Randome(number); //генерирум первые очки
        System.Console.WriteLine($"{userName}! У вас {userNumber}.");   //показываем очки пользователю
        if (userNumber < 21)
        {
            for (int j = 0; j < 100; j++)    //цикл для добора очков
            {
                String select = InputString("Ещё? (Да/Нет)");   //спрашиваем пользователя - добирать или нет
                if (select.ToLower() == "да")
                {
                    userNumber = userNumber + Randome(number);  //добавляем очки к существующим
                    System.Console.WriteLine($"{userName}! У вас {userNumber}.");   //показываем очки пользователю
                }
                else
                {
                    break;
                }

                if (userNumber > 21)
                {
                    break;
                }
            }
        }
        npsNumber = NPSGame(npsNumber);
        if (userNumber > 21)
        {
            System.Console.WriteLine($"{userName}! У вас {userNumber}. Вы проиграли!");
            npsIndex++;
        }
        else if (npsNumber > 21)
        {
            System.Console.WriteLine($"{userName}! У меня {npsNumber}. Вы выиграли!");
            userIndex++;
        }
        else if (userNumber < npsNumber)
        {
            System.Console.WriteLine($"{userName}! У вас {userNumber}, а у меня {npsNumber}. Вы проиграли!");
            npsIndex++;
        }
        else if (userNumber > npsNumber || npsNumber > 21)
        {
            System.Console.WriteLine($"{userName}! У вас {userNumber}, а у меня {npsNumber}. Вы выиграли!");
            userIndex++;
        }
        else
        {
            System.Console.WriteLine($"{userName}! У вас {userNumber} и у меня {npsNumber}. Ничья!");
        }
    }
    if (userIndex > npsIndex)
    {
        System.Console.WriteLine($"{userName}! Вы победитель!");
    }
    else if (userIndex == npsIndex)
    {
        System.Console.WriteLine($"{userName}! У нас ничья!");
    }
    System.Console.WriteLine($"{userName}! Я победитель!");
    return;
}