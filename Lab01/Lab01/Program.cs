using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            double val2;
            Console.WriteLine("Please Enter your NAME:");
            str = Console.ReadLine();
            Console.WriteLine("Your name is: " + str);

            Console.WriteLine("Please Enter your LASTNAME:");
            str = Console.ReadLine();
            Console.WriteLine("Your lastname is: " + str);

            Console.WriteLine("Please Enter your ID:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your ID is: "+val1);

            Console.WriteLine("Please Enter your GPA:");
            double Val2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Your ID is: " + Val2);




        }
    }
}
