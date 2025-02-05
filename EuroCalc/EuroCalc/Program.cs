namespace EuroCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deuro = 2.575;
            var maaR = 6378;
            maaR *= 100000;

            var Pmaa = 2 * 3.14 * maaR;
            var Peuro = Pmaa / deuro;

            Console.WriteLine(Pmaa + " " + Math.Round(Peuro, 3));
            

        }
    }
}
