namespace CoffePrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loo puramiid tarnidest");
            Console.Write("----------------------");
            Console.Write("\n\n");
            Console.WriteLine("Seisesta puramiidi suurus");

            int i, j, n;

            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
