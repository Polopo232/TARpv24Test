using System.Linq.Expressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            string ch = Console.ReadLine();

            switch(ch)
            {
                case "a":
                    Console.WriteLine("vokaal a");
                    break;
                
                case "e":
                    Console.WriteLine("vokaal v");
                    break;
                
                case "i":
                    Console.WriteLine("vokaal a");
                    break;


                default:
                    Console.WriteLine("ei ole bla bla bla");
                    break;
            }

        }
    }
}
