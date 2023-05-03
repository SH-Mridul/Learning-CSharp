using System;
using System.Threading.Channels;

namespace Constructor
{
    public class Progam
    {


        //static constructor (its call implicitly and static constructor can't be parameterized,so overloading not possible)
        static Progam()
        {
            Console.WriteLine("static constructor.");
        }
        public static void Main(string[] args)
        {

            //there are 4 type of constructor
            // 1.Default or parameter less constructor
            // 2.Parameterized Constructor
            // 3.Copy Constructor
            // 4.Static Constructor

            Person person = new();
            person.Name = "mridul";
            Console.WriteLine(person.Name);
            Console.ReadLine();
        }
    }
}