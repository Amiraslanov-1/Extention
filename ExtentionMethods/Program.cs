using System;

namespace StaticLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Group No :");
            string str=Console.ReadLine();
            while (!Student.CheckGroupNo(str))
            {
                Console.WriteLine("Enter Correctly :");
                str = Console.ReadLine();
            }



            Console.WriteLine("Enter FullName:");
            string fullName = Console.ReadLine();
            while (!Student.CheckFullName(str))
            {
                Console.WriteLine("Enter Correctly : ");
                str = Console.ReadLine();
            }




        }

        
    }
}
