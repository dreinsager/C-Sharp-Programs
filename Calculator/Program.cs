using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                string title = "---My Calculator Application--- \n \n";
                

            while (true)
            {
                //Centering the title
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                //Change the title color
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(title);
                Console.ResetColor();
                            Console.WriteLine("Choose which operation you like to use. ( +, -, *, /)");
            string operation;
            operation = Console.ReadLine();

                    //If statement for performing the operations
            if (operation == "+")
            {
                Console.WriteLine("Please enter your first number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your second number:");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 + num2;
                Console.WriteLine("The answer is " + result);

            } else if (operation == "-")

            {
                Console.WriteLine("Please enter your first number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your second number:");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 - num2;
                Console.WriteLine("The answer is " + result);

            } else if (operation == "*")

            {
                Console.WriteLine("Please enter your first number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your second number:");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 * num2;
                Console.WriteLine("The answer is " + result);

            } else if (operation == "/")

            {
                Console.WriteLine("Please enter your first number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your second number:");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("The answer is " + result);

            } else

            {
                Console.WriteLine("Please enter a valid operator");
                continue;
            }


                // Prompt user to do another calculation to continue or end program
                Console.WriteLine("Would you like to do another calculation? [Y or N]");
                string prompt = Console.ReadLine().ToUpper();
                
                if (prompt == "Y") 
                {
                    continue;
                }
                else if (prompt == "N") 
                {
                    return;
                }
                else 
                {
                    return;
                }
            
            }

        }
    }
}
