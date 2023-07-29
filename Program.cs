using System.ComponentModel.Design;

namespace Ask1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Hector!");

            // ask1
            double a, b;

            Console.WriteLine("Write a number ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Write another  number");
            b = double.Parse(Console.ReadLine());

            if (b != 0)
            {
                Console.WriteLine("the result is " + a / b);
            }    
            else
            {
                Console.WriteLine("ERROR B CANOT BE 0 ");
            }

                
        } 
    } 
}