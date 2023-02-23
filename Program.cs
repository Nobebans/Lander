using System.Xml;

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

            //sverige.Print();
            //tyskland.Print();
            //sanMarino.Print();

            Land[] länder = new Land[7];
            länder[0] = sverige;
            länder[1] = tyskland;
            länder[2] = sanMarino;
            länder[3] = new Land { namn = "Danmark", styretyp = "monarki", huvudstad = "Köpenhamn", invånarantal = "5928364" };
            länder[4] = new Land { namn = "Italien", styretyp = "republik", huvudstad = "Rom", invånarantal = "58853482" };
            länder[5] = new Land { namn = "Tjekien", styretyp = "republik", huvudstad = "Prag", invånarantal = "10551219" };
            länder[6] = new Land { namn = "Rumänien", styretyp = "republik", huvudstad = "Bukarest", invånarantal = "19760314" };

            //foreach (Land land in länder)
            //{
            //    land.Print();
            //}

            for (int i = 0; i <= länder.Length; i++)
            {
                if (länder[i].styretyp == "republik")
                {
                    Console.WriteLine(länder[i].namn);
                }               
            }
        }
    }
}
