using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static readonly char[] del = new char[] { '/', '+', '*', '%', '^' };
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(@"
                / = Division
                + = Addition
                * = Multiplication
                % = Percent (25%1000=250)
                ^ = To Power Of (5^2=25)
                ");
                Console.Write("Enter Equation (23*56): ");
                var calcEquation = Console.ReadLine().Replace(" ", "");

                foreach (var c in calcEquation)
                {
                    if (!Char.IsDigit(c))
                    {
                        if (del.Contains(c))
                        {
                            var n1 = Convert.ToInt32(calcEquation.Substring(0, calcEquation.IndexOf(c)));
                            var n2 = Convert.ToInt32(calcEquation.Substring(calcEquation.IndexOf(c) + 1, calcEquation.Length - (calcEquation.IndexOf(c) + 1)));

                            switch (c)
                            {
                                case '/':
                                    Console.WriteLine($"Answer = {n1 / n2}");
                                    break;

                                case '+':
                                    Console.WriteLine($"Answer = {n1 + n2}");
                                    break;

                                case '*':
                                    Console.WriteLine($"Answer = {n1 * n2}");
                                    break;

                                case '%':
                                    Console.WriteLine($"Answer = {((double)n2 / 100) * n1}");
                                    break;

                                case '^':
                                    Console.WriteLine($"Answer = {Math.Pow(n1, n2)}");
                                    break;

                                default:
                                    return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                    }
                }
                Console.WriteLine("Press Enter To Do More");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
