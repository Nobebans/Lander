namespace Länder
{
    internal class Program
    {
        public class Land
        {
            public string namn, styretyp, huvudstad, invånarantal;

            public void Print()
            {
                Console.WriteLine($"land: {namn}");
                Console.WriteLine($"styretyp: {styretyp}");
                Console.WriteLine($"huvudstad: {huvudstad}");
                Console.WriteLine($"invånarantal: {invånarantal}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Land sverige = new Land() { namn = "Sverige", styretyp = "monarki", huvudstad = "Stockholm", invånarantal = "10512820" };
            Land tyskland = new Land() { namn = "Tyskland", styretyp = "republik", huvudstad = "Berlin", invånarantal = "83783902" };
            Land sanMarino = new Land() { namn = "San Marino", styretyp = "republik", huvudstad = "San Marino", invånarantal = "33600" };

            sverige.Print();
            tyskland.Print();
            sanMarino.Print();
        }
    }
}