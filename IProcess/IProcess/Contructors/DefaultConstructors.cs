using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Contructors
{
    public class DefaultConstructors
    {
        public DefaultConstructors()
        {

        }

        /*
         A constructor without any parameters is called a default constructor
         The drawback of a default constructor is that every instance of the class will be initialized to the same values and it is not possible to initialize each instance of the class with different values
         All numeric fields in the class to zero.
         string and object fields to null.
          */

        public void defaultConstructorCheck()
        {
            Console.WriteLine("Default Constructor working");
            Console.ReadLine();
        }
    }
}
