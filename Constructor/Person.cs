using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public String Email { get; set; }


        // Explicit Constructor(implicit constructor is which constructor define by compiler)
        
        public Person()
        { 

        }
        // Parameterized Constructor(a constructor with parameter)
        public Person(String name,int age,String email) 
        {
            Name = name;
            Age = age;
            Email = email;
        }



        //Copy constructor(Basically its do copy data from another object. it also known as paramiterized constructor)
        public Person(Person person) 
        {
            Name = person.Name;
            Age = person.Age;
            Email = person.Email;
        }
    }
}
