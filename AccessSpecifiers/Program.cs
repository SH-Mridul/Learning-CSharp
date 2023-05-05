using System;
using System.Threading.Channels;

namespace AccessSpecifiers 
{
    public class Progam
    {
        public static void Main(string[] args)
        {
            //c# has five access spacifier
            //1. private(the method is only access able within the class)
            //2. internal(internal accessable in a project)
            //3. protected(protected accessable in child class)

            //4. protected internal(if internal and protected not accessable then the protected internal is also not accesable,
            //when we create an object in another project then it will be not accessable)

            //5. public (access from full solution)

            //in same class we can call every method whatever access specifiers it use no metter will
            //come here.

            //we can make a class public and internal
            Console.WriteLine("----calling from parent class-----");
            Person person = new Person();
            person.InternalMethod();
            person.ProtectedInternalMethod();
            person.PublicMethod();

            Console.WriteLine("----calling from child class----");
            Employee employee = new Employee();
            Console.WriteLine("-----method calling from employee---------");
            employee.InternalMethod();
            employee.ProtectedInternalMethod();
            employee.PublicMethod();
            Console.WriteLine("-----method calling end---------");
            Console.WriteLine("--------------------------------");


            Console.ReadLine();
        }
    }
}