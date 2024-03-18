namespace Potnhatárok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány pontja lett a 100-ból?: ");
            int pontszam = int.Parse(Console.ReadLine());

            if (pontszam < 0 || pontszam > 100)
            {
                Console.WriteLine("Az adat hibás!");
            }
            else if (pontszam > 0 & pontszam < 50)
            {
                Console.WriteLine("Az érdemjegye: 1");
            }
            else if (pontszam >= 50 & pontszam < 65)
            {
                Console.WriteLine("Az érdemjegye: 2");
            }
            else if (pontszam >= 65 && pontszam < 80)
            {
                Console.WriteLine("Az érdemjegye: 3");
            }
            else if (pontszam >= 80 && pontszam < 90)
            {
                Console.WriteLine("Az érdemjegye: 4");
            }
            else if (pontszam >= 90)
            {
                Console.WriteLine("Az érdemjegye: 5");
            }
        }
    }
}