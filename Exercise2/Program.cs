using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("============Primitive Types And Variables Excercise============");
//Question 1
/*
void Question1()
{
    sbyte SBYTE = 224;
    byte BYTE = 224;
    short Short = -44;
    ushort UShort = 224;
    int INT = -10000;
    uint UInt = 970700000;
    long Long = -1000000;
    ulong ULong = 123456789123456789;
}
//Question 2
void Question2()
{
    float FLOAT = -5.01F;
    double DOUBLE = 8923.1234857;
    decimal Decimal = 3456.091124875956542151256683467M;
}*/
//Question 3
/*static void Question3(double number1 , double number2)
{
    Console.WriteLine("We are comparing two numbers. Number 1 and Number2");
    if (number1 == number2)
    {
        Console.WriteLine($"{number1} is equal to {number2}");
    }
    else if (number1 > number2)
    {
        Console.WriteLine($"{number1} is greater than {number2}");
    }
    else if(number1 < number2)
    {
        Console.WriteLine($"{number1} is less than {number2}");
    }
}
Question3(445.002, 455.003);
*/
// Question 4
/*static void Question4()
{
    int intvalue = 256;
    string hexavalue = intvalue.ToString("X");
    Console.WriteLine(hexavalue);
}
Question4();
*/
//Question 5
/*static void Question5()
{
    char Character = 'H';
    Console.WriteLine(Convert.ToInt32(Character));
}
Question5();
*/
//Question 6
/*static void Question6()
{
    bool Ismale = true;
}
*/
//Question 7
/*static void Question7()
{
    String NAME = "Hello";
    string word = "World";
    object other = "How are you?";
    Console.WriteLine($"{NAME} {word} {other}");
}
Question7();*/
//Question 8
/*static void Question8()
{
    String NAME = "Hello";
    string word = "World";
    object other = "How are you?";
    string casting = (string)other;
    Console.WriteLine($"{NAME} {word} {other}");
}
Question8();
*/
//Question 9
// static void Question9()
// {
//     string Quotedstring = "The \"use\" of quotations causes difficulties.";
//     string NonQuotedString = "The use of quotations causes difficulties.";
//     Console.WriteLine(Quotedstring + "\n" +NonQuotedString);
// }
// Question9();

//Question 10
// static void Question10()
// {
//     Console.WriteLine(" o   o\no o o o");
// }
// Question10();

//Question 11
// static void Question11()
// {
//     string Triangle = "isosceles triangle";
//     string symbol = "©";
//     Console.WriteLine(Triangle + symbol);
// }
//Question11();
//QUESTION 12
// static void Question12()
// {
//   string [] firstname
//   string [] lastname
//   int [] age
//   char gender (‘m’ or ‘f’)
// }

//Class example
// for (int i = 97; i <= 122; i++)
// {
//     Console.Write(Convert.ToChar(i) + " ");
// }

//Question 13
void Question13()
{
    int value1 = 5;
    int value2 = 10;
    Console.WriteLine("Value1 " + value1 + "\n" + "Value2 " + value2);
    int swap = value1;
    value1 = value2;
    value2 = swap;
    Console.WriteLine("Value1 " + value1 + "\n" + "Value2 " + value2);
}
Question13();