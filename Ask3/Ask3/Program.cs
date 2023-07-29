namespace Ask3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Hector!");

            // ask3

            string name1, name2;
            int tall1, tall2;

            Console.WriteLine("Write a basketball player name ");
            name1 = Console.ReadLine();

            Console.WriteLine("Write " + name1 + " hight");
            tall1 =int.Parse(Console.ReadLine());

            Console.WriteLine("Write another  basketball player name ");
            name2 = Console.ReadLine();

            Console.WriteLine("Write " + name2 + " hight");
            tall2 = int.Parse(Console.ReadLine());

            if (tall1 > tall2)
            {
                Console.WriteLine(name1 + " is taller than " + name2);
            }
            else if  (tall1 < tall2)
            {
               Console.WriteLine(name2 + " is taller than " + name1);
            }
            else if (tall2 == tall1)
            {
                Console.WriteLine("They are the same hight");
            }

        }
    }
}






















