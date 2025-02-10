using System.Xml.XPath;

namespace IfElseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input number 1");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Insert calculation type by number");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            string math = Console.ReadLine();
            Console.WriteLine("input 2 number: ");
            float num2 = float.Parse(Console.ReadLine());

            float result = 0;

            if (math == "1")
            {
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
            }
            else if (math == "2")
            {
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
            }
            else if (math == "3")
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
            }
            else if (math == "4")
            {
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
            }
            else
            {
                Console.WriteLine("Fortnite GAME error");
            }

        }
    }
}
