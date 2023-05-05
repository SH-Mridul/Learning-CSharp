using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    public class Person
    {
        private void PrivateMethod()
        {
            Console.WriteLine("A private method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("A internal method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("A protected method");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("A protected internal method");
        }

        public void PublicMethod()
        {
            Console.WriteLine("A public method");
        }
    }
}
