using System;
using System.Threading.Channels;

namespace StaticConstructorAndNonStaticConstructor
{
    public class Progam
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person();
            Console.ReadLine();
        }
    }
}