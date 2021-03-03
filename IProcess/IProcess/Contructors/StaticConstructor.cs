using System;
using System.Collections.Generic;
using System.Text;

namespace IProcess.Contructors
{
    /*
     a constructor is created using a static keyword,
     it will be invoked only once for all of the instances of the class and it is invoked during the creation of the first instance of the class
     A static constructor is used to initialize static fields of the class 
     to write the code that needs to be executed only once
     static constructor not allowed to use access specifier
     we can't able to use static and const key with same variable creation
         */
    public class StaticConstructor
    {
        static readonly int a = 10;
        static readonly int b =   20;

        static StaticConstructor()
        {
            a = 100;
            b = 200; 
        }

    public void sample()
        {
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
