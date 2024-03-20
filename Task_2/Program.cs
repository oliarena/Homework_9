using System;

namespace Task_2
{
    internal class Program
    {
        delegate double Calculator(int a, int b);

        static void Main(string[] args)
        {
            int x;
            int y;
            string? sign;
            Calculator? calc;

            while (true)
            {
                calc = null;
                x = GetNumber();
                y = GetNumber();
                
                Console.Write("Please enter the action {0} ...    ", (y != 0) ? "/ ,* ,- or + " : "*, - or + ");
                sign = Console.ReadLine();
                
                switch (sign)
                {
                    case "/":
                        calc = (a, b) =>
                        {
                            if (b != 0)
                            {
                                return (double)a / b;
                            }
                            else
                            {
                                Console.WriteLine("Dividing by zero is forbidden.");
                                return 0;
                            }
                        };
                        break;
                    case "*":
                        calc = (a, b) => a * b;
                        break;
                    case "-":
                        calc = (a, b) => a - b;
                        break;
                    case "+":
                        calc = (a, b) => a + b;
                        break;

                    default:
                        Console.WriteLine("The entered action is wrong. Please, try again... ");
                        break;
                }
                
                if (calc != null)
                {
                    Console.WriteLine("{0} {2} {1} = {3} ", x, y, sign, calc(x, y));
                }
                
            }
        }

        static int GetNumber()
        {
            int number;

            Console.Write("Please enter the number ...");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Number is incorrect. Please, try again... ");
            }

            return number;
        }

        static void PrintResult(int operand1, int operand2, string action, double result)
        {
           
        }
    }
}