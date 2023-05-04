using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructorAndNonStaticConstructor
{
    public class Person
    {
        public String? Name { get; set; }
        static int Count = 0;

        //non static constructor call explicitly,when object created it will call.
        //it work for initial deafult value to different value.
        //it can be overload and we can pass parameter of it
        public Person()
        {
            Console.WriteLine("hello from non static");
        }


        //static constructor execute immediately onece the class execution of a class.
        //it will execute at first then execute the non static constructor.
        //where it will place no matter,it will execute first and it's for initial static field
        //it's a first block of code under a class for process.
        //it's call implicitly
        //how much object we create or what ever,static constructor call just once
        //we can't pass any parameter in static constructor
        //non static constructor can not be overload

        static Person()
        {
            Console.WriteLine("hello from static");
        }

        public static void GetName()
        {
            Console.WriteLine("get name from static");
        }


    }
}
