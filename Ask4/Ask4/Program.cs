using System.Xml.Linq;

namespace Ask4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Hector!");

            // ask4

            float number ;

            Console.WriteLine("Write a  number ");
            number = float.Parse (Console.ReadLine());

            if (number < 0) 
            {
                Console.WriteLine(number + number * -2);
                //Console.WriteLine(Math.Abs(number));
            }
            else
            {
                Console.WriteLine(number);
            }
            
        }
    }
} 