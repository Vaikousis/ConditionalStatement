using System.Xml.Linq;

namespace Ask2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Hector!");

            // ask2
            int XiliometraPouDienuseEnaAmmajiApoThnHmeraAgoeas,
                XiliometraPouDienuseThStigmhPouEkaneToTeleuuteoService;

            Console.WriteLine("ta xilimetra pou dienise to ammaji apo thn hmera agoras");
           XiliometraPouDienuseEnaAmmajiApoThnHmeraAgoeas = int.Parse(Console.ReadLine());

            Console.WriteLine("Kai ta xiliometra pou dienuse th stigmh pou ekane to teleuteo service");
            XiliometraPouDienuseThStigmhPouEkaneToTeleuuteoService = int.Parse(Console.ReadLine());

            int xiliometraApoToTeleuteoService = XiliometraPouDienuseEnaAmmajiApoThnHmeraAgoeas - XiliometraPouDienuseThStigmhPouEkaneToTeleuuteoService;


            if (xiliometraApoToTeleuteoService >= 15000)
            {
                Console.WriteLine("SERVICE");
            }
            else if ( xiliometraApoToTeleuteoService >= 0 && xiliometraApoToTeleuteoService < 15000 )
             {
             Console.WriteLine("NO SERVICE");
             }
            else if (xiliometraApoToTeleuteoService < 0)
             {
                Console.WriteLine("Wrong DATA");
            }




        }
    }
    }
            