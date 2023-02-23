namespace Länder
{
    internal class Program
    {
        public class Land
        {
            public string namn, styretyp, huvudstad, invånarantal;
        }

        static void Main(string[] args)
        {
            Land Sverige = new Land() { styretyp = "monarki", huvudstad = "Stockholm", invånarantal = "10512820" };
            Land Tyskland = new Land() { styretyp = "republik", huvudstad = "Berlin", invånarantal = "83783902" };
            Land SanMarino = new Land() { styretyp = "republik", huvudstad = "San Marino", invånarantal = "33600" };
        }
    }
}