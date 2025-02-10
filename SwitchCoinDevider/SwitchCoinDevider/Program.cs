namespace SwitchCoinDevider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input coins: ");
            var coins = int.Parse(Console.ReadLine());

            var fifty = coins / 50;
            coins -= fifty * 50;

            var twen = coins / 20;
            coins -= twen * 20;

            var ten = coins / 10;
            coins -= ten * 10;

            var five = coins / 5;
            coins -= five * 5;

            var two = coins / 2;
            coins -= two * 2;

            var one = coins;

            Console.WriteLine("");
            if (fifty > 0)
                Console.WriteLine(fifty + " - 50 cents");
            if (twen > 0) 
                Console.WriteLine(twen + " - 20 cents");
            if (ten > 0) 
                Console.WriteLine(ten + " - 10 cents");
            if (five > 0) 
                Console.WriteLine(five + " - 5 cents");
            if (two > 0) 
                Console.WriteLine(two + " - 2 cents");
            if (one > 0) 
                Console.WriteLine(one + " - 1 cent");
        }
    }
}
