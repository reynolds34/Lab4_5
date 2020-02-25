using System;
using System.Collections;

namespace Lab4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList al = new ArrayList();
            al.Add("4400");
            al.Add("8900");
            al.Add("1200");
            al.Add("3700");
            al.Add("7200");

            Console.WriteLine("Your list scores.");
            Console.WriteLine(" ");
            foreach (string i in al)
                Console.WriteLine(i);
            Console.WriteLine(" ");

            Console.WriteLine("Press Enter to display your list scores from lowest to highest.");
            Console.ReadLine();
            al.Sort();
            foreach (string i in al)
                Console.WriteLine(i);
            Console.WriteLine(" ");

            Console.WriteLine("Press Enter to display your list scores from highest to lowest.");
            Console.ReadLine();
            al.Reverse();
            foreach (string i in al)
                Console.WriteLine(i);
            Console.WriteLine(" ");

            Console.WriteLine("A new score of 2400 has been added to the list, press Enter to reveal the added score in the list.");
            Console.ReadLine();
            al.Add("2400");
            foreach (string i in al)
            Console.WriteLine(i);
            Console.WriteLine(" ");


            Console.WriteLine("The score 4400 has been removed from the list, press Enter to reveal the updated list.");
            Console.ReadLine();
            al.Remove("4400");
            foreach (string i in al)
                Console.WriteLine(i);
            Console.WriteLine(" ");



        }
    }
}
