namespace Squid_game_TARpv24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus, kus " +
                "kontrollitakse stringi abil värvi vastavust");

            Console.WriteLine("Värvide valikuks on: red, blue, green ja white");

            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei siseta" +
                "eelpoool sisestatud värvi");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.WriteLine("You have chosen red color");
            }
            else if (color == "blue")
            {
                Console.WriteLine("You have chosen blue color");
            }
            else if (color == "green")
            {
                Console.WriteLine("You have chosen green color");
            }
            else if (color == "white")
            {
                Console.WriteLine("You have chosen white color");
            }
            else
            {
                Console.WriteLine("Incorrect input !");
            }

        }
    }
}
