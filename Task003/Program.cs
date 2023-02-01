int[] userCard = CreateCard(4);
int[] npsCard = CreateCard(4);


Console.WriteLine("Игра: Верю не верю");
String userName = InputString("Давай знакомиться!? Как тебя зовут");
System.Console.WriteLine($"Привет, {userName}!");
String select = InputString("Начнём игру? (Да/Нет)");
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

int Randome(int randome)
{
    Random rnd = new Random();
    randome = rnd.Next(1, 4);
    return randome;
}

int[] CreateCard(int size)
{
    int[] card = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < 4; i++)
    {
        card[i] = rnd.Next(1, 4); 
    }
    return card;
}

void PrintUserCard(int[] userCard)
{
    System.Console.WriteLine($"Ваши карты, {userName}: ");
    for (int i = 0; i < 4; i++)
    {
        System.Console.Write($"|{userCard[i]}| ");
    }
    System.Console.WriteLine("");
    System.Console.WriteLine($" 1   2   3   4");
}

void Game()
{
    PrintUserCard(userCard);
    return;
}