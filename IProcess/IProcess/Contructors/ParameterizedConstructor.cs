using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Contructors
{
   public class ParameterizedConstructor
    {
        int a;
        int b;
        /*
         A constructor with at least one parameter is called a parameterized constructor
         The advantage of a parameterized constructor is that you can initialize each instance of the class with a different value
             */
        public ParameterizedConstructor(int _a , int _b)
        {
            a = _a;
            b = _b;
        }

        public void Add()
        {
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
