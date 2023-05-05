using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    public class Employee : Person
    {
        public Employee() 
        {
            Console.WriteLine("--------employee constructor----------------");
            ProtectedMethod();
            ProtectedInternalMethod();
            InternalMethod();
            PublicMethod();
            Console.WriteLine("--------employee constructor end-------------");
        }
    }
}
