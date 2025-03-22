// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Random dice = new Random();
//int roll =dice.Next(0, 7);
// Console.WriteLine(roll);
using System.Net;

double num1, num2, result;
string operatorChoice = "+";
bool flad = true;


        

        while (flad)
        {
         // Displaying the menu
        Console.WriteLine("Simple Console Calculator");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Press 'y' to Continue Caclculation or Press 'n' to exit");
       
        string confirmation = Console.ReadLine();

        if (confirmation == "y"|| confirmation == "Y")
        {
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Get the operator choice
        Console.WriteLine("Enter the operator (+, -, *, /): ");
        operatorChoice = Console.ReadLine();

        // Get the second number
        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Perform calculation based on the operator choice
        switch (operatorChoice)
        {
            case "+":
                result = num1 + num2;
                Console.WriteLine($"Result: {num1} + {num2} = {result}");
                break;
            case "-":
                result = num1 - num2;
                Console.WriteLine($"Result: {num1} - {num2} = {result}");
                break;
            case "*":
                result = num1 * num2;
                Console.WriteLine($"Result: {num1} * {num2} = {result}");
                break;
            case "/":
                // Handle division by zero
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("nError: Cannot divide by zero.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                break;
        }

        }

        else
        {
        Console.WriteLine("Exiting...");
        Console.WriteLine("Thanks for Choosing the App");
        Console.WriteLine("-------------------------");
        flad = false;
        }
            // Get the first number
        
        }

        


