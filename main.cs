using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------\n");

        while (true)
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Modulus (%)");
            Console.WriteLine("6. Square Root (√)");

            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine("\n");

            double result;
            bool isValidOperation = true;

            switch (operation)
            {
                case '1':
                    result = num1 + num2;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '2':
                    result = num1 - num2;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '3':
                    result = num1 * num2;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '4':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        isValidOperation = false;
                    }
                    break;
                case '5':
                    result = num1 % num2;
                    Console.WriteLine($"Result: {result}");
                    break;
                case '6':
                    if (num1 >= 0)
                    {
                        result = Math.Sqrt(num1);
                        Console.WriteLine($"Result: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Square root of a negative number is not defined.");
                        isValidOperation = false;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    isValidOperation = false;
                    break;
            }

            if (isValidOperation)
            {
                Console.WriteLine("\nPress any key to continue or 'Q' to quit.");
                char key = Char.ToUpper(Console.ReadKey().KeyChar);
                if (key == 'Q')
                {
                    break;
                }
                Console.WriteLine("\n");
            }
        }
        Console.WriteLine("Program finished. Press any key to exit.");
        Console.ReadKey();
    }
}
