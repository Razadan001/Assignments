// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Hello, World!");
//Question1
// static void Question1()
// {
//     int a, b, c, d;
//     Console.Write("Input three numbers let's ssum them.\nInput 1: ");
//     a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input 2: ");
//     b = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input 3: ");
//     c = Convert.ToInt32(Console.ReadLine());
//     d = a + b + c;
//     Console.WriteLine($"The sum of the three numbers is {d}");
// }
// Question1();

//Question 2
// static void Question2()
// {
//     double radius = Convert.ToDouble(Console.ReadLine());
//     double area = 2 * Math.PI * radius;
//     Console.WriteLine("The area of a circle is: " + area);
// }
// Question2();

//Question3
// static void Question3()
// {
//     //Company Information
//     Console.WriteLine("=====Enter company information=====\nCompany Name: ");
//     string companyName = Console.ReadLine()!;
//     Console.Write("Company Address: ");
//     string companyAddress = Console.ReadLine()!;
//     Console.Write("Company Phone Number: ");
//     string companyPhoneNumber = Console.ReadLine()!;
//     Console.Write("Company Fax Number: ");
//     string? companyFaxNumber = Console.ReadLine();
//     Console.Write("Company Website: ");
//     string? companyWebsite = Console.ReadLine();

//     //Manager informations
//     Console.WriteLine("\n=====Enter manager information=====\nManager's First Name: ");
//     string? managerFirstName = Console.ReadLine();
//     Console.Write("Manager's Last Name: ");
//     string? managerLastName = Console.ReadLine();
//     Console.Write("Manager's Phone Number: ");
//     string? managerPhoneNumber = Console.ReadLine();
    
//     Console.WriteLine("\nCompany Information:");
//     Console.WriteLine("Company Name: " + companyName);
//     Console.WriteLine("Company Address: " + companyAddress);
//     Console.WriteLine("Company Phone Number: " + companyPhoneNumber);
//     Console.WriteLine("Company Fax Number: " + companyFaxNumber);
//     Console.WriteLine("Company Website: " + companyWebsite);

//     Console.WriteLine("\nManager Information:");
//     Console.WriteLine("Manager's Name: " + managerFirstName + " " + managerLastName);
//     Console.WriteLine("Manager's Phone Number: " + managerPhoneNumber);
// }
// Question3();

//Question4
// static void Question4()
// {
//     int number1 = 75;          // Integerhexadecimal
//     double number2 = 34.56;  //Fraction positive number
//     double number3 = -68.454;  // Negative fraction number
//     Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-35:F9}", number1, number2, number3);
// }
// Question4();
// Question5
// static void Question5()
// {
//     Console.Write("Input 1: ");
//     int Input1 = int.Parse(Console.ReadLine()!);

//     Console.Write("Input 2: ");
//     int Input2 = int.Parse(Console.ReadLine()!);

//     int count = 0;

//     for (int i = Input1; i <= Input2; i++)
//     {
//         if (i % 5 == 0)
//         {
//             count++;
//         }
//     }

//     Console.WriteLine($"There are {count} numbers between {Input1} and {Input2} that are divisible by 5.");
// }
// Question5();


//Question 6
// static void Question6()
// {
//     Console.Write("Enter the first number: ");
//     double firstNumber = double.Parse(Console.ReadLine());

//     Console.Write("Enter the second number: ");
//     double secondNumber = double.Parse(Console.ReadLine());

//     double greaterNumber = Math.Max(firstNumber, secondNumber);

//     Console.WriteLine($"The greater number is: {greaterNumber}");
// }
// Question6();


//Question7
// static void Question7()
// {
//     Console.Write("Enter the first number: ");
//     int Number1 = int.Parse(Console.ReadLine()!);

//     Console.Write("Enter the second number: ");
//     int Number2 = int.Parse(Console.ReadLine()!);

//     Console.Write("Enter the third number: ");
//     int Number3 = int.Parse(Console.ReadLine()!);

//     Console.Write("Enter the fourth number: ");
//     int Number4 = int.Parse(Console.ReadLine()!);

//     Console.Write("Enter the fifth number: ");
//     int Number5 = int.Parse(Console.ReadLine()!);
//     int Total = Number5 + Number4 + Number3 + Number2 + Number1;
//     Console.WriteLine("The Sum of the five numbers is: " + Total);
// }
// Question7();

//Question8
// static void Question8()
// {
//     Console.Write("Enter the first number: ");
//     int Number1 = int.Parse(Console.ReadLine()!);

//     Console.Write("Enter the second number: ");
//     int Number2 = int.Parse(Console.ReadLine()!);

//     Console.Write("Enter the third number: ");
//     int Number3 = int.Parse(Console.ReadLine()!);

//     Console.Write("Enter the fourth number: ");
//     int Number4 = int.Parse(Console.ReadLine()!);

//     Console.Write("Enter the fifth number: ");
//     int Number5 = int.Parse(Console.ReadLine()!);
//     if (Number1 > Number2 && Number1 > Number3 && Number1 > Number4 && Number1 > Number5)
//     {
//         Console.WriteLine(Number1 + " Is the greatest");
//     }
//     else if (Number2 > Number1 && Number2 > Number3 && Number2 > Number4 && Number2 > Number5)
//     {
//         Console.WriteLine(Number2 + " Is the greatest");
//     }
//     else if (Number3 > Number1 && Number3 > Number2 && Number3 > Number4 && Number3 > Number5)
//     {
//         Console.WriteLine(Number3 + " Is the greatest");
//     }
//     else if (Number4 > Number1 && Number4 > Number2 && Number4 > Number3 && Number4 > Number5)
//     {
//         Console.WriteLine(Number4 + " Is the greatest");
//     }
//     else if (Number5 > Number1 && Number5 > Number2 && Number5 > Number3 && Number5 > Number4)
//     {
//         Console.WriteLine(Number5 + " Is the greatest");
//     }
//     else
//     {
//         Console.WriteLine("Invalid expression");
//     }
// }
// Question8();

//Question 9
// static void Question9()
// {
//     Console.WriteLine("How many numbers do you want to sum ?: ");
//     int reply = int.Parse(Console.ReadLine()!);
//     for (int i = 0; i <= reply; i++)
//     {
//         Console.Write("Enter the first number: ");
//         int Number1 = int.Parse(Console.ReadLine()!);
//         Console.Write("Enter the next number: ");
//         int Number2 = int.Parse(Console.ReadLine()!);
        
//     }
    

// }
// Question9();

//Question 10
// static void Question10()
// {
//     Console.Write("Enter a Number:");
//     int.TryParse(Console.ReadLine(), out int reply);
//     for (int i = 1; i <= reply; i++)
//     {
//         Console.Write(i + "\n");
//     }
// }
// Question10();

//Question 11
static void Question11()
{
    int fibanocci0 = 0;
    int fibanocci1 = 1;
    int count = 1;
    int i = 1;
    while (i <= 100)
    {
        
        Console.WriteLine(i);
    }
}
Question11();