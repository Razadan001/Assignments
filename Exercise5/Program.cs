using System;
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
