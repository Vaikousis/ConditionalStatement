using System.ComponentModel.Design;
using System.Xml.Linq;

namespace Ask6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Hector!");
            float bk;

            Console.WriteLine("poso baumous kelsiou exeis?");
            bk = float.Parse(Console.ReadLine());

            if (bk >= 35.5 && bk < 37)
            {
                Console.WriteLine("Fusiologikos");
            }
            else if (bk >= 37 && bk < 38)
            {
                Console.WriteLine("zestos");
            }
            else if (bk >= 38 && bk < 42)
            {
                Console.WriteLine("Arostos");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
