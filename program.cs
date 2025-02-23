using System;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("------------------");
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();

            if (choice == "5") break;

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = calculator.Add(num1, num2);
                    break;
                case "2":
                    result = calculator.Subtract(num1, num2);
                    break;
                case "3":
                    result = calculator.Multiply(num1, num2);
                    break;
                case "4":
                    result = calculator.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
