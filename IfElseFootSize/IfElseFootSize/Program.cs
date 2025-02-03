namespace IfElseFootSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var input = Console.ReadLine();
            var size = int.Parse(input);

            if (size >= 30 && size <= 33) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
            }
            else if (size >= 34 && size <= 38)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("");
            }
            else if (size >= 39 && size <= 44)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("");
            }
            else if (size >= 45 && size <= 48)
            {
                Console.Beep();
            }
            else
            {
                Console.WriteLine("111");
            }
        }   
    }
}
