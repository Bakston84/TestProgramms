(int, int)Parameters()  //Функция определения N-параметров
{
    int a = 2;
    int b = 5;
    return (a, b);
}

void SumParameters()    //Функция суммирования N-параметров 
{
    (int a, int b) = Parameters();
    int sum = a + b;
    System.Console.WriteLine(sum);
}

SumParameters();