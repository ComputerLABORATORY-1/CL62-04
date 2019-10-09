using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int randomNumber = random.Next(0,9);


            Console.WriteLine("Plese you enter number:");
            Console.WriteLine(randomNumber);
            int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a);

            bool b = randomNumber == a;
            Console.WriteLine("{0}", b);
            Console.ReadKey();





        }
    }
}
