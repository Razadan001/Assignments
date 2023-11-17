// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Question1
/*Write a program that prints on the console the numbers from 1 to N. 
The number N should be read from the standard input*/
// static void Question1()
// {
//     Console.Write("Enter a number, let count from 1 to the number!!!\nNumber: ");
//     int number = int.Parse(Console.ReadLine()!);
//     for (int i = 0; i <= number; i++)
//     {
//         Console.WriteLine(i);
//     }
// }
// Question1();

//Question2
/*Write a program that prints on the console the numbers from 1 to N, 
which are not divisible by 3 and 7 simultaneously. The number N 
should be read from the standard input.
*/
// static void Question2()
// {
//     Console.Write("Input a number and let's check the numbers that are not divisible by 3 and 7.\nNumber:");
//     int number = int.Parse(Console.ReadLine()!);
//     for (int num = 1; num <= number; num++)
//     {
//         if (!(num % 3 == 0) && !(num % 7 == 0))
//         {
//             Console.WriteLine(num);
//         }
//     }
// }
// Question2();

// Question3
/*Write a program that reads from the console a series of integers and 
prints the smallest and largest of them
*/
// static void Question3()
// {
//     Console.WriteLine("Enter a series of number let's check the smallest and biggest\nNumbers: ");
//     double number = double.Parse(Console.ReadLine()!);
//     double numberCount = number;
// }
// Question3();


//Question5
/*Write a program that reads from the console number N and print the sum 
of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
13, 21, 34, 55, 89, 144, 233, 377
*/
// static void Question5()
// {
//     Console.Write("Input a number let's print the fibanocci sequence.\nNumber: ");
//     int number = int.Parse(Console.ReadLine()!);
//     int numb = 0;
//     int sum = 1;
//     int add = numb + sum;
//     Console.WriteLine("The fibanocci is : \n {0} {1}", numb, sum);
//     while (numb <= number)
//     {
//         numb++;
//         add += add;
//         Console.Write(add + ", ");
//     }
// }
// Question5();

// Question12
/*Write a program that converts a given number from decimal to binary 
notation (numeral system).*/
static void Question12()
{
    Console.Write("\tConvert Decimal To Binary");
    Console.Write("\nPlease enter an integer you want to convert into binary notation:\nDecimal Number: ");
    BinaryWriter decNum = Convert.(Console.ReadLine()!);
    Console.WriteLine($"Binary representation of {decNum}: " );
}
Question12();
