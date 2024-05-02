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
        Console.WriteLine($"Enter numbers to calculator:");

        string[] numberInputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (numberInputs.Length < 2)
        {
            Console.WriteLine("Invalid Input. Enter at least 2 numbers");
            continue;
        }

        double[] numbers = new double[numberInputs.Length];
        bool isValidInput = true;

        for (int i = 0; i < numberInputs.Length; i++)
        {
            if (!double.TryParse(numberInputs[i], out numbers[i]))
            {
                Console.WriteLine($"Invalid input: '{numberInputs[i]}'. Enter valid numbers");
                isValidInput = false;
                break;
            }
        }

        if (!isValidInput)
        {
            continue;
        }

        double result = 0;

        switch (optn)
        {
            case '+':
                result = numbers.Sum();
                break;

            
        }

        Console.WriteLine($"Result: {string.Join(" " + optn + " ", numbers)} = {result}");
    }
    else
    {
        Console.WriteLine("Invalid operation. Enter a valid operation(+,-,*,/) or 'exit' to quit");
    }
}
