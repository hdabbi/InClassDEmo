using System;
using System.Diagnostics;

namespace InClassDEmo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            Console.WriteLine("Your first number:");
            try
            {
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("My Number is: " + Num1);
                Console.WriteLine("My New Number is:" + Num1+33);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


                 
        }
    }
}
