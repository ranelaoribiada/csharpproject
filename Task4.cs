using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose Operation: 1-Add  2-Sub  3-Mul  4-Div");
            string choice = Console.ReadLine();

            Console.Write("Enter Value 1: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter Value 2: ");
            double b = double.Parse(Console.ReadLine());

            double result = 0;
            bool valid = true;

            switch (choice)
            {
                case "1": result = a + b; break;
                case "2": result = a - b; break;
                case "3": result = a * b; break;
                case "4":
                    if (b == 0) { Console.WriteLine("Cannot divide by zero."); valid = false; }
                    else result = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid option."); valid = false;
                    break;
            }

            if (valid) Console.WriteLine("Result = " + result);

            Console.Write("\nContinue? (Y/N): ");
            if (Console.ReadLine().ToUpper() == "N") break;
            Console.WriteLine();
        }
    }
}
