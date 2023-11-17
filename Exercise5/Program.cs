using System;
using Humanizer;
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
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
// 

//Question 3
// static void Question3()
// {
//     int num1, num2, num3;
//     Random random = new Random();
//     num1 = random.Next(0,5);
//     num2 = random.Next(0, 5);
//     num3 = random.Next(0, 5);
//     if(num1 > num2 && num1 > num3)
//     {
//         Console.WriteLine($"The biggest number is: {num1} out of {num1}, {num2}, {num3}");
//     }
//     else if(num2 > num1 && num2 > num3)
//     {
//         Console.WriteLine($"The biggest number is: {num2} out of {num1}, {num2}, {num3}");
//     }
//     else if(num3 > num1 && num3 > num2)
//     {
//         Console.WriteLine($"The biggest number is: {num3} out of {num1}, {num2}, {num3}");
//     }
//     else
//     {
//         Console.Write("Unexcpected number");
//     }
// }
// Question3();

//Question 4
// static void Question4()
// {
//     int num1, num2, num3;
//     Console.Write("Input number: ");
//     num1 = int.Parse(Console.ReadLine()!);
//     Console.Write("Input number: ");
//     num2 = int.Parse(Console.ReadLine()!);
//     Console.Write("Input number: ");
//     num3 = int.Parse(Console.ReadLine()!);
//     if(num1 > num2 && num1 > num3 && num2 > num3)
//     {
//         Console.WriteLine($"Arranged in Descending order.\n{num1}\n{num2}\n{num3}");
//     }
//     else if(num1 > num2 && num1 > num3 && num3 > num2)
//     {
//         Console.WriteLine($"Arranged in Descending order.\n{num1}\n{num3}\n{num2}");
//     }
//     else if(num2 > num1 && num2 > num3 &&  num1 > num3)
//     {
//         Console.WriteLine($"Arranged in Descending order.\n{num2}\n{num1}\n{num3}");
//     }
//     else if(num2 > num1 && num2 > num3 &&  num3 > num1)
//     {
//         Console.WriteLine($"Arranged in Descending order.\n{num2}\n{num3}\n{num1}");
//     }
//     else if(num3 > num1 && num3 > num2 && num2 > num1)
//     {
//         Console.WriteLine($"Arranged in Descending order.\n{num3}\n{num2}\n{num1}");
//     }
//     else if(num3 > num1 && num3 > num2 && num1 > num2)
//     {
//         Console.WriteLine($"Arranged in Descending order.\n{num3}\n{num1}\n{num2}");
//     }
//     else
//     {
//         Console.Write("Unexcpected number");
//     }
// }
// Question4();

// Question 5;
static void Question5()
{
    Console.Write("Input a number: ");
    int userInput = int.Parse(Console.ReadLine()!);
    switch (userInput)
    {
        case 0:
            Console.WriteLine("0 to word is \"ZERO\"");
        break;
        case 1:
            Console.WriteLine("1 to word is \"ONE\"");
        break;
        case 2:
            Console.WriteLine("2 to word is \"TWO\"");
        break;
        case 3:
            Console.WriteLine("3 to word is \"THREE\"");
        break;
        case 4:
            Console.WriteLine("4 to word is \"FOUR\"");
        break;
        case 5:
            Console.WriteLine("5 to word is \"FIVE\"");
        break;
        case 6:
            Console.WriteLine("6 to word is \"SIX\"");
        break;
        case 7:
        Console.WriteLine("7 to word is \"SEVEN\"");
        break;
        case 8:
            Console.WriteLine("8 to word is \"EIGHT\"");
        break;
        case 9:
            Console.WriteLine("9 to word is \"NINE\"");
        break;
        default:
            Console.WriteLine("Counting");
        break;
    }
}
Question5();


// static void Question7()
// {
//     int num1, num2, num3, num4, num5;
//     Random random = new Random();
//     Console.Write("Input number: ");
//     num1 = int.Parse(Console.ReadLine()!);
//     Console.Write("Input number: ");
//     num2 = int.Parse(Console.ReadLine()!);
//     Console.Write("Input number: ");
//     num3 = int.Parse(Console.ReadLine()!);
//     Console.Write("Input number: ");
//     num4 = int.Parse(Console.ReadLine()!);
//     Console.Write("Input number: ");
//     num5 = int.Parse(Console.ReadLine()!);
//     if(num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
//     {
//         Console.WriteLine($"The biggest number is: {num1} out of {num1}, {num2}, {num3}, {num4}, {num5}");
//     }
//     else if(num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
//     {
//         Console.WriteLine($"The biggest number is: {num2} out of {num1}, {num2}, {num3}, {num4}, {num5}");
//     }
//     else if(num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
//     {
//         Console.WriteLine($"The biggest number is: {num3} out of {num1}, {num2}, {num3}, {num4}, {num5}");
//     }
//     else if(num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
//     {
//         Console.WriteLine($"The biggest number is: {num4} out of {num1}, {num2}, {num3}, {num4}, {num5}");
//     }
//     else if(num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
//     {
//         Console.WriteLine($"The biggest number is: {num5} out of {num1}, {num2}, {num3}, {num4}, {num5}");
//     }
//     else
//     {
//         Console.Write("Unexcpected number");
//     }
// }
// Question7();
//Question8
// static void Question10()
// {
//     int score, mult;
//     Console.Write("Input any number: ");
//     score = int.Parse(Console.ReadLine()!);
//     if (score == 1 || score == 2 || score == 3)
//     {
//         mult = score * 10;
//         Console.WriteLine($"Your bonus score is: {mult}");
//     }
//     else if (score == 4 || score == 5 || score == 6)
//     {
//         mult = score * 100;
//         Console.WriteLine($"Your bonus score is: {mult}");
//     }
//     else if (score == 7 || score == 8 || score == 9)
//     {
//         mult = score * 1000;
//         Console.WriteLine($"Your bonus score is: {mult}");
//     }
//     else if (score == 0 || score > 9)
//     {
//         Console.WriteLine("Invalid expression");
//     }
//     else
//     {
//         Console.WriteLine("Syntax error");
//     }
// }
// Question10();

//Question11
// static void Question11()
// {
//     Console.Write("Input any number, let me tell you the number in words.\nInput: ");
//     int input = int.Parse(Console.ReadLine()!);
//     Console.WriteLine($"{input} in words is {input.ToWords()}");
// }
// Question11();


