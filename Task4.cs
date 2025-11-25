using System;
class ArithmeticCalculator
{
    // --- Methods for Arithmetic Operations ---
    static double Add(double a, double b)
    {
        return a + b;
    }
    static double Substract(double a, double b)
    {
        return a - b;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
    static double Divide(double a, double b)
    {
        return a / b;    
    }
    static void Main()
    {
        char again = 'Y';

        while (again == 'Y'  || again == 'y')
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.Writeline("1 - Addition");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            Console.Write("Your Choice: ");
            string choice = Console.ReadLine();

            Console.Write("Enter Value 1: ");
            double value1 = Convert \.ToDouble(Console.ReadLine());

            Console.Write("Enter Value 2: ");
            double value2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            string operationSymbol = "";

            // Switch case to choose operation 
            switch (choice)
            {
                case "1":
                    result = Add(value1, value2);
                    operationSymbol = "+";
                    break;

                case "2"
                    result = Substract(value1, value2);
                    operationSymbol = "-";
                    break;
                case "3"
                    result = Multiply(value1, value2);
                    operationSymbol = "*";
                case "4" 
                   if (value2 ==0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                        continue; // restart loop
                    }
                    // Output
                    Console.WriteLine($"{value1} {operationSymbol} {value2} = {result}");

                    //Ask user to continue
                    Console.Write("Do you want to continue again (Y/N)? ");
                    again = Console.ReadKey().KeyChar;
                    Console.WriteLine();
            }

            Console.WriteLine("Thank you for using the calculator!");
        }
    }    
    
                    
