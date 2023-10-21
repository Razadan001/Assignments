// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Question 1
// static void Question1()
// {
//     int Number1 = 10;
//     int Number2 = 20;

//     if (Number1 > Number2)
//     {
//         int exchange = Number1;
//         Number1 = Number2;
//         Number2 = exchange;
//     }
// }
// Question1();    


//Question2
static void Question2()
{
    Console.Write("Enter the first real number: ");
    double number1 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter the second real number: ");
    double number2 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter the third real number: ");
    double number3 = double.Parse(Console.ReadLine()!);

    char Symbol = '+';

    if (number1 < 0)
    {
        Symbol = (number2 < 0) ? '+' : '-';
    }
    else if (number2 < 0)
    {
        Symbol = (number3 < 0) ? '+' : '-';
    }
    else if (number3 < 0)
    {
        Symbol = '-';
    }

    Console.WriteLine("The sign of the product is: " + Symbol);
}
