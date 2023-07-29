namespace Ask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double leutaLogariasmou, posaLeutaUaBgaleis;
            double sunolo;

            Console.WriteLine("posa leuta exeis ston logargiasmo sou?");
            leutaLogariasmou = float.Parse(Console.ReadLine());

            Console.WriteLine("posa leuta ua bgaleis apo to ATM?");
            posaLeutaUaBgaleis = float.Parse(Console.ReadLine());

            double promiuia = 1.0/100 * posaLeutaUaBgaleis;

            if (promiuia < 1)
            {
                promiuia = 1;
            }
            else if (promiuia > 3)
            {
                promiuia = 3;

            }

            sunolo = posaLeutaUaBgaleis +  promiuia;

            if (leutaLogariasmou >= sunolo)

            {
                Console.WriteLine("EBGALES " + sunolo + " euro");
                leutaLogariasmou -= sunolo;
                Console.WriteLine("H promiuia einai afth = " + promiuia);
                Console.WriteLine("kai to sunolo pou thasas exei minei ston logariasmo einai = " + leutaLogariasmou);
            }
            else
            {
                Console.WriteLine("den mporei na pragmatopithh");
            }
        }
    }
}