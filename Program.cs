using System;

bool continueCalcuating = true;

while (continueCalcuating)
{
    Console.WriteLine("Simple Calculator");
    Console.WriteLine("Enter an operation(+,-,*,/) or 'exit' to quit");

    string input = Console.ReadLine().ToLower();

    if (input == "exit")
    {
        continueCalcuating = false;
        Console.WriteLine("Exiting calculator ...");
        break;
    }

    char optn;
    if (input.Length == 1 && "+-*/".Contains(input))
    {
        optn = input[0];
        Console.WriteLine($"Enter the first number:");
        double num1;

        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Enter a valid number.");
            continue;
        }

        Console.WriteLine($"Enter the second number:");
        double num2;

        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Enter a valid number.");
            continue;
        }

        double result = 0;

        switch (optn)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    continue;
                }
                result = num1 / num2;
                break;

            default:
                Console.WriteLine("Invalid Operation. Try again");
                continue;
        }

        Console.WriteLine($"Result: {num1} {optn} {num2} = {result}");
    }
    else
    {
        Console.WriteLine("Invalid operation. Enter a valid operation(+,-,*,/) or 'exit' to quit");
    }
}
